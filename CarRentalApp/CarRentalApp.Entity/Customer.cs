using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApp.Entity
{
    
        public class Customer
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }

            // Bir müşteri birden fazla rezervasyona sahip olabilir.
            public virtual List<Reservation> Reservations { get; set; }
        }
    

}
