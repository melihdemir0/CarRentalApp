using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentalApp.Entity;

namespace CarRentalApp.Data.Repositories
{
    public class CarImageRepository : BaseRepository<CarImage>
    {
        public CarImageRepository(CarRentalContext context) : base(context)
        {
        }

        // CarImage'a özel metotlar burada tanımlanabilir
    }
}

