using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentalApp.Data.Repositories;
using CarRentalApp.Entity;

namespace CarRentalApp.Business
{
    public class ReservationBusiness : BaseBusiness<Reservation>
    {
        public ReservationBusiness(IRepository<Reservation> repository) : base(repository)
        {
        }

        // Reservation'a özel iş mantığı metotları burada tanımlanabilir
    }
}

