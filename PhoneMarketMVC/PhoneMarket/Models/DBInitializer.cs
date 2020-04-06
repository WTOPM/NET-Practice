using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PhoneMarket.Models
{
    public class DBInitializer : DropCreateDatabaseAlways<PhoneContext>
    {
        protected override void Seed(PhoneContext context)
        {
            context.Phones.Add(new Phone() { Name = "Xiomi MI8", Price = 8000, Producer = "Xiomi"} );

            context.Phones.Add(new Phone() { Name = "Xiomi MI9TPro", Price = 10000, Producer = "Xiomi" });

            context.Phones.Add(new Phone() { Name = "Samsung Galaxy S10", Price = 25000, Producer = "Samsung" });

            base.Seed(context);
        }
    }
}