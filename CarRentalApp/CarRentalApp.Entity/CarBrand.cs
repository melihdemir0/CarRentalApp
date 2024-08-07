using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApp.Entity
{
    public class CarBrand
        {
            public int Id { get; set; }
            public string Name { get; set; }

            // Bir marka birden fazla arabaya sahip olabilir.
            public virtual List<Car> Cars { get; set; }
        }
    

}

