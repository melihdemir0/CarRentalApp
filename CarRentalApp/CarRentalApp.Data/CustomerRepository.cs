using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentalApp.Entity;

namespace CarRentalApp.Data.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>
    {
        public CustomerRepository(CarRentalContext context) : base(context)
        {
        }

        // Customer'a özel metotlar burada tanımlanabilir
    }
}

