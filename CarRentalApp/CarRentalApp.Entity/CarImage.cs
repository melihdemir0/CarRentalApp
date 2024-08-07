using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApp.Entity
{
    
        public class CarImage
        {
            public int Id { get; set; }
            public string ImageUrl { get; set; }

            // Yabancı anahtar ve ilişki
            public int CarId { get; set; }
            public virtual Car Car { get; set; }
        }
    

}
