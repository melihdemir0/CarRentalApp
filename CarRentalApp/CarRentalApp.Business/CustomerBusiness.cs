using CarRentalApp.Data.Repositories;
using CarRentalApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarRentalApp.Business
{
    public class CustomerBusiness : BaseBusiness<Customer>
    {
        public CustomerBusiness(IRepository<Customer> repository) : base(repository)
        {
        }

        // Customer'a özel iş mantığı metotları burada tanımlanabilir
    }
}

