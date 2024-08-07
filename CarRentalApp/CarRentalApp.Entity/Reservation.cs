using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApp.Entity
{
    
        public class Reservation
        {
            public int Id { get; set; }
            public int CarId { get; set; }
            public int CustomerId { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }

            // İlişkiler
            public virtual Car Car { get; set; }
            public virtual Customer Customer { get; set; }
        }
  

}
