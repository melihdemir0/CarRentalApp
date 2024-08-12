using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentalApp.Entity;

namespace CarRentalApp.Data.Repositories
{
    public class CarRepository : BaseRepository<Car>
    {
        public CarRepository(CarRentalContext context) : base(context)
        {
        }

        // Car'a özel metotlar burada tanımlanabilir
    }
}

