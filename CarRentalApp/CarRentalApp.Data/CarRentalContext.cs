using CarRentalApp.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApp.Data
{
    public class CarRentalContext : DbContext
    {
        public CarRentalContext() : base("name=CarRentalDB") 
        {
        }

        public virtual DbSet<CarBrand> CarBrands { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<CarImage> CarImages { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
    }
}
