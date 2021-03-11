using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SynchSQKServer.Models;

namespace SynchSQKServer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Host=localhost;Port=5432;Database=usersdb;Username=postgres;Password=password
            Console.WriteLine("Hello World!");
            Console.WriteLine(LegalForms.IP.Description());
            Console.WriteLine(EnumHelper.GetEnumValue<LegalForms>("ИП").Description());
            Console.ReadLine();
            Synch.SynchOrganizations.OrgReestr();
            Synch.SynchOrganizations.SynchT();
            using(ClientsContext db=new ClientsContext())
            {
                var orgs = db.Organizations.Where(o => EF.Functions.Like(o.Alias, "%Орлова%"));
                foreach (Organization org in orgs)
                {
                    org.Contacts.Add(new Contact
                    {
                        Fio = "Орлова А. Е.",
                        Phone = "8 919"
                    });
                };
                db.SaveChanges();
            }
        }
    }
}
