using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentalApp.Entity;

namespace CarRentalApp.Data.Repositories
{
    public class CarBrandRepository : BaseRepository<CarBrand>
    {
        public CarBrandRepository(CarRentalContext context) : base(context)
        {
        }

        // CarBrand'a özel metotlar burada tanımlanabilir
    }
}

