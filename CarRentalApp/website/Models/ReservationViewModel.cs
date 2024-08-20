using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace website.Models
{
    
        public class ReservationViewModel
        {
            public int ReservationId { get; set; }
            public int CarId { get; set; }
            public string CarModel { get; set; }
            public int CarYear { get; set; }
            public bool CarIsAvailable { get; set; }
            public int CarBrandId { get; set; }
            public string CarBrandName { get; set; }
            public int CustomerId { get; set; }
            public string CustomerFirstName { get; set; }
            public string CustomerLastName { get; set; }
            public string CustomerEmail { get; set; }
            public string CustomerPhoneNumber { get; set; }
            public DateTime ReservationStartDate { get; set; }
            public DateTime ReservationEndDate { get; set; }
        }
    }

