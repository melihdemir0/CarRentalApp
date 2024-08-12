using CarRentalApp.Data.Repositories;
using CarRentalApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarRentalApp.Business
{
    public class CarBusiness : BaseBusiness<Car>
    {
        public CarBusiness(IRepository<Car> repository) : base(repository)
        {
        }

        // Car'a özel iş mantığı metotları burada tanımlanabilir
    }
}
