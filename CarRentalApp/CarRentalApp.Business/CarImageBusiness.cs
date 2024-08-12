using CarRentalApp.Data.Repositories;
using CarRentalApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarRentalApp.Business
{
    public class CarImageBusiness : BaseBusiness<CarImage>
    {
        public CarImageBusiness(IRepository<CarImage> repository) : base(repository)
        {
        }

        // CarImage'a özel iş mantığı metotları burada tanımlanabilir
    }
}

