using System;
using System.Collections.Generic;
using SynchDB.MSQL;
using SynchDB.PgSQL;
using System.Linq;

namespace SynchDB
{
    class Program
    {
        static void Main(string[] args)
        {
            clients_siContext dbMSql = new clients_siContext();
            ClientsContext dbPgSql = new ClientsContext();

            var viewOrganizations = dbPgSql.ViewOrglists.ToList();
            foreach (var o in viewOrganizations)
                Console.WriteLine(o.DateEd);
            ICollection<ConvertCommands> commands = new List<ConvertCommands>()
            {
                /*
                ConvertCommands.SynchOrg,
                ConvertCommands.SynchContact,
                ConvertCommands.SynchRates
                ConvertCommands.SynchLicenseeLD
                */
            };
            foreach(var cmd in commands)
                switch (cmd)
                {
                    case ConvertCommands.RemoveOrg:
                        dbPgSql.Organizations.RemoveRange(dbPgSql.Organizations);
                        dbPgSql.SaveChanges();
                        break;
                    case ConvertCommands.SynchOrg:
                        var orglist = dbMSql.Organizations.ToList();
                        var rateList = dbMSql.RateLists.ToList();

                        foreach (var o in orglist)
                        {
                            foreach (var o1 in dbMSql.OrgNotes)
                            {
                                Guid g = Guid.Parse(o1.GuidOrg);
                                if (o.Id == g)
                                {
                                    var org = new PgSQL.Organization
                                    {
                                        Alias = o.OrgName,
                                        LegalForm = (int)EnumHelper.GetEnumValue<LegalFromEnum>(o1.LegalForm),
                                        Name = o1.OrgNameOriginal,
                                        NameFull = $"{o1.LegalForm} {o1.OrgNameOriginal}",
                                        Inn = o1.Inn,
                                        Kpp = o1.Kpp,
                                        Ogrn = o1.Ogrn,
                                        BankName = o1.Bank,
                                        BankBik = o1.Bik,
                                        BankAccount = o1.RShet,
                                        BankCorrsepondentAccount = o1.KorShet,
                                        DirectorName = o1.Director,
                                        DirectorDolgnost = o1.Dolgnost,
                                        Sqlguid = o.Id.ToString()
                                    };
                                    if (o.Date != "" && o.Date != null)
                                        org.ContractsEds.Add(new PgSQL.ContractsEd
                                        {
                                            Num = o.Contract,
                                            Date = Convert.ToDateTime(o.Date)
                                        });
                                    if (o.DateLd != "" && o.DateLd != null)
                                        org.ContractsLds.Add(new ContractsLd
                                        {
                                            Num = o.ContractLd,
                                            Date = Convert.ToDateTime(o.DateLd)
                                        });
                                    dbPgSql.Organizations.Add(org);
                                    break;
                                };
                            };
                        };
                        dbPgSql.SaveChanges();
                        break;
                    case ConvertCommands.SynchRates:
                        var org1 = dbPgSql.Organizations.ToList();
                        var rates = dbMSql.RateLists;
                        foreach(var r in rates)
                        {
                            Guid rg = Guid.Parse(r.IdOrg);
                            foreach (var o in org1)
                            {
                                Guid g = Guid.Parse(o.Sqlguid);
                                if (rg == g)
                                    o.TarifsEds.Add(new TarifsEd
                                    { 
                                        DateApply=Convert.ToDateTime(r.Date),
                                        Name=r.Name,
                                        LetterFileName=r.LetterFilename
                                    });
                            }
                        }
                        dbPgSql.SaveChanges();
                        break;
                    case ConvertCommands.SynchContact:
                        foreach (var o in dbPgSql.Organizations)
                            foreach (var c in dbMSql.Contacts)
                                if (Guid.Parse(c.IdOrg) == Guid.Parse(o.Sqlguid))
                                {
                                    o.Contacts.Add(new PgSQL.Contact
                                    {
                                        Fio = c.Fio,
                                        Phone = c.Phone1,
                                        Phone1 = c.Phone2,
                                        Email = c.Mail,
                                        Post = c.Post,
                                        IsRepresentative = c.Predstavitel
                                    });
                                }
                        dbPgSql.SaveChanges();
                        break;
                    case ConvertCommands.SynchLicenseeLD:
                        Console.WriteLine(" ------ ");
                        Console.WriteLine(dbMSql.ViewLicenseeLDRelation.Where(o=>o.ParentOrgName!="").Count());
                        Console.WriteLine(" ------ ");

                        Dictionary<Guid, Guid> licRelations = new Dictionary<Guid, Guid>();
                        foreach (var org in dbMSql.ViewLicenseeLDRelation.Where(org => org.ParentOrgName != ""))
                            licRelations.Add(org.ChildrenID, org.ParentID);

                        Dictionary<Guid, int> parentOrgList = new Dictionary<Guid, int>();
                        var organizations = dbPgSql.Organizations.ToList();
                        foreach (var parentID in dbMSql.ViewLicenseeLDRelation.Where(org => org.ParentOrgName != "").Select(org => org.ParentID).Distinct())
                        {
                            var org= organizations.FirstOrDefault(o =>
                            {
                                Guid guid = Guid.Parse(o.Sqlguid);
                                if (guid == parentID)
                                    return true;
                                else
                                    return false;
                            });
                            parentOrgList.Add(parentID, org.Id);
                        };

                        foreach (var org in dbPgSql.Organizations)
                            foreach (var relation in licRelations)
                                if (Guid.Parse(org.Sqlguid) == relation.Key)
                                    org.LicenseeLDIdOrg = parentOrgList[relation.Value];
                        dbPgSql.SaveChanges();
                                //Console.WriteLine(String.Join(',', dbMSql.ViewLicenseeLDRelation.Where(o => o.ParentOrgName != "").Select(o => o.ParentOrgName).ToArray()));
                                break;
                }

            //dbPgSql.Contacts.RemoveRange(dbPgSql.Contacts);
            /*
            dbPgSql.ContractsEds.RemoveRange(dbPgSql.ContractsEds);
            dbPgSql.ContractsLds.RemoveRange(dbPgSql.ContractsLds);
            dbPgSql.TarifsEds.RemoveRange(dbPgSql.TarifsEds);
            */
            /*
            ClientsContext dbPgSql = new ClientsContext();

            dbPgSql.Organizations.RemoveRange(dbPgSql.Organizations);
            dbPgSql.Contacts.RemoveRange(dbPgSql.Contacts);
            dbPgSql.ContractsEds.RemoveRange(dbPgSql.ContractsEds);
            dbPgSql.ContractsLds.RemoveRange(dbPgSql.ContractsLds);
            dbPgSql.TarifsEds.RemoveRange(dbPgSql.TarifsEds);
            */
        }
    }
}
