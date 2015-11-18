using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestApi.Models
{
    public class MyContextInitializer : DropCreateDatabaseAlways<ApplicationContext>
    {
        protected override void Seed(ApplicationContext context)
        {
            base.Seed(context);

            context.People.Add(new Person
            {
                FirstName = "Arkadiusz",
                LastName = "Stępniewski",
                Age = 22,
                Profession = "student"
            });

            context.People.Add(new Person
            {
                FirstName = "Michał",
                LastName = "Kruk",
                Age = 32,
                Profession = "mechanik"
            });

            context.SaveChanges();
        }
    }
}