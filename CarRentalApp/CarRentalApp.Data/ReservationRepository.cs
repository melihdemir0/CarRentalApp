using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentalApp.Entity;

namespace CarRentalApp.Data.Repositories
{
    public class ReservationRepository : BaseRepository<Reservation>
    {
        public ReservationRepository(CarRentalContext context) : base(context)
        {
        }

        // Reservation'a özel metotlar burada tanımlanabilir
    }
}
