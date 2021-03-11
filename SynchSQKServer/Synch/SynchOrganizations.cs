using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SynchSQKServer.Models;

namespace SynchSQKServer.Synch
{
    public static class SynchOrganizations
    {
        public static bool OrgReestr()
        {
            using (SqlConnection con = new SqlConnection(Param.ConnectionString))
            using (var db = new ClientsContext())
                try
                {
                    db.Organizations.RemoveRange(db.Organizations);
                    db.Contacts.RemoveRange(db.Contacts);
                    db.ContractsEd.RemoveRange(db.ContractsEd);
                    db.ContractsLd.RemoveRange(db.ContractsLd);
                    db.TarifsED.RemoveRange(db.TarifsED);
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "select * FROM organizations o, org_note o1 WHERE o.id=o1.guid_org";
                    SqlDataReader dr = cmd.ExecuteReader();
                    while(dr.Read())
                    {
                        string guid = dr["id"].ToString();
                        string alias = dr["org_name"].ToString();
                        int legalForm = (int) EnumHelper.GetEnumValue<LegalForms>(dr["legal_form"].ToString());
                        string orgName = dr["org_name_original"].ToString();
                        string director = dr["director"].ToString();
                        string dolgnost = dr["dolgnost"].ToString();
                        string polnomochia = dr["polnomochia"].ToString();
                        string inn = dr["inn"].ToString();
                        string kpp = dr["kpp"].ToString() == "" ? null : dr["kpp"].ToString();
                        string ogrn = dr["ogrn"].ToString() == "" ? null : dr["ogrn"].ToString();
                        string bankAccount = dr["r_shet"].ToString() == "" ? null : dr["r_shet"].ToString();
                        string bankCorrespondentAccount = dr["kor_shet"].ToString() == "" ? null : dr["kor_shet"].ToString();
                        string bankName = dr["bank"].ToString() == "" ? null : dr["bank"].ToString();
                        string bik = dr["bik"].ToString() == "" ? null : dr["bik"].ToString();
                        db.Organizations.Add(new Organization
                        {
                            Alias = alias,
                            LegalForm = legalForm,
                            Name = orgName,
                            NameFull = orgName,
                            Inn = inn,
                            Kpp = kpp,
                            DirectorName = director,
                            DirectorDolgnost = dolgnost,
                            BankName = bankName,
                            BankAccount = bankAccount,
                            BankCorrsepondentAccount = bankCorrespondentAccount,
                            BankBik = bik,
                            SQLGuid = guid
                        });
                        db.SaveChanges();
                    }
                    if (!UpdateContacts())
                        return false;
                    if (!SynchContracts())
                        return false;
                    if (!SynchTarifs())
                        return false;
                    return true;
                }
                catch (SystemException ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
        }

        public static bool UpdateContacts()
        {
            using(ClientsContext db=new ClientsContext())
                using(SqlConnection con=new SqlConnection(Param.ConnectionString))
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT id, id_org, ISNULL(Post,'') AS Post, ISNULL(Fio,'') AS Fio, ISNULL(phone1,'') AS Phone, ISNULL(phone2,'') AS Phone1, ISNULL(Mail,'') AS Email, predstavitel FROM contacts";
                    SqlDataReader dr = cmd.ExecuteReader();
                    List<Contact> contacts = new List<Contact>();
                    while (dr.Read())
                    {
                        string id = dr["id"].ToString();
                        string idOrg = dr["id_org"].ToString();
                        string post = dr["Post"].ToString()=="" ? null : dr["Post"].ToString();
                        string fio = dr["Fio"].ToString();
                        string phone = dr["Phone"].ToString() == "" ? null : dr["Phone"].ToString();
                        string phone1 = dr["Phone1"].ToString() == "" ? null : dr["Phone1"].ToString();
                        string email = dr["Email"].ToString() == "" ? null : dr["Email"].ToString();
                        int predstavitel = Convert.ToInt32(dr["predstavitel"]);
                        contacts.Add(new Contact
                        {
                            SQLGuid = id,
                            SQLGuidOrg=idOrg,
                            Fio = fio,
                            Post = post,
                            Phone = phone,
                            Phone1 = phone1,
                            Email = email,
                            isRepresentative = predstavitel
                        });
                    }
                    foreach (var o in db.Organizations)
                        foreach (var c in contacts)
                            if (o.SQLGuid == c.SQLGuidOrg)
                                o.Contacts.Add(c);
                    db.SaveChanges();
                    return true;
                }
                catch(SystemException ex)
                {
                    return false;
                };
        }

        public static bool SynchContracts()
        {
            using(ClientsContext db=new ClientsContext())
            using (SqlConnection con=new SqlConnection(Param.ConnectionString))
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT id, date, contract, date_ld, contract_ld FROM Organizations";
                    SqlDataReader dr = cmd.ExecuteReader();
                    List<ContractEd> contractsEd = new List<ContractEd>();
                    List<ContractLD> contractLDs = new List<ContractLD>();
                    while (dr.Read())
                    {
                        string id = dr["id"].ToString();
                        if (dr["Contract"].ToString() != "" & dr["Date"].ToString() != "")
                        {
                            string contract = dr["Contract"].ToString();
                            DateTime date = Convert.ToDateTime(dr["Date"]);
                            contractsEd.Add(new ContractEd
                            {
                                Num = contract,
                                Date = date,
                                SQLGuid = id
                            });
                        }
                        if (dr["contract_ld"] != DBNull.Value)
                            if (dr["contract_ld"].ToString() != "" & dr["date_ld"].ToString() != "")
                            {
                                string contract = dr["contract_ld"].ToString();
                                DateTime date = Convert.ToDateTime(dr["date_ld"]);
                                contractLDs.Add(new ContractLD
                                {
                                    Num = contract,
                                    Date = date,
                                    SQLGuid = id
                                });
                            }
                    }
                    dr.Close();
                    foreach(var o in db.Organizations)
                    {
                        foreach (var c in contractsEd)
                            if (o.SQLGuid == c.SQLGuid)
                                o.ContractsEd.Add(c);
                        foreach (var c in contractLDs)
                            if (o.SQLGuid == c.SQLGuid)
                                o.ContractsLd.Add(c);
                    }
                    db.SaveChanges();
                }
                catch(SystemException ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
                return true;
        }

        static bool SynchTarifs()
        {
            using(ClientsContext db=new ClientsContext())
                using(SqlConnection con=new SqlConnection(Param.ConnectionString))
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT * FROM rate_list";
                    SqlDataReader dr = cmd.ExecuteReader();
                    List<TarifED> tarifsED = new List<TarifED>();
                    while (dr.Read())
                        if (dr["Name"].ToString() != "")
                        {
                            var tarif = new TarifED
                            {
                                SQLGuid = dr["id_org"].ToString(),
                                Name = dr["Name"].ToString(),
                                DateApply = Convert.ToDateTime(dr["Date"]),
                                LetterFileName = dr["letter_filename"] == DBNull.Value ? null : dr["Letter_filename"].ToString()
                            };
                            tarifsED.Add(tarif);
                            foreach (var o in db.Organizations)
                                if (tarif.SQLGuid == o.SQLGuid)
                                    o.TarifsED.Add(tarif);
                        };
                    dr.Close();
                    foreach (var t in tarifsED)
                        foreach (var o in db.Organizations)
                        {
                            if (o.SQLGuid == t.SQLGuid)
                            {
                                Console.WriteLine(t.SQLGuid);
                                o.TarifsED.Add(t);
                            }
                        }
                    db.SaveChanges();
                }
                catch(SystemException ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            return true;
        }

        public static void SynchT()
        {
            using (ClientsContext db = new ClientsContext())
            using (SqlConnection con = new SqlConnection(Param.ConnectionString))
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT * FROM rate_list";
                    SqlDataReader dr = cmd.ExecuteReader();
                    List<TarifED> tarifsED = new List<TarifED>();
                    while (dr.Read())
                        if (dr["Name"].ToString() != "")
                        {
                            var tarif = new TarifED
                            {
                                SQLGuid = dr["id_org"].ToString(),
                                Name = dr["Name"].ToString(),
                                DateApply = Convert.ToDateTime(dr["Date"]),
                                LetterFileName = dr["letter_filename"] == DBNull.Value ? null : dr["Letter_filename"].ToString()
                            };
                            tarifsED.Add(tarif);
                            Console.WriteLine(db.Organizations.Where(o => EF.Functions.Like( o.SQLGuid, $"%{tarif.SQLGuid}%")).Count());
                        };
                    dr.Close();
                    db.SaveChanges();
                }
                catch (SystemException ex)
                {
                    Console.WriteLine(ex.Message);
                }
        }

        static bool SynchPosts()
        {

            return true;
        }
    }
}
