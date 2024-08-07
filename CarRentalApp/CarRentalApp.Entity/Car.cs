using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApp.Entity
{
    public class Car
        {
            public int Id { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public bool IsAvailable { get; set; }

            // Yabancı anahtarlar ve ilişkiler
            public int BrandId { get; set; }
            public virtual CarBrand Brand { get; set; }

            // Bir araba birden fazla resme sahip olabilir.
            public virtual List<CarImage> Images { get; set; }
        }
    }


