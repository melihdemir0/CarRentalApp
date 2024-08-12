using CarRentalApp.Data.Repositories;
using CarRentalApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace CarRentalApp.Business
{
    public class CarBrandBusiness : BaseBusiness<CarBrand>
    {
        public CarBrandBusiness(IRepository<CarBrand> repository) : base(repository)
        {
        }

        // CarBrand'a özel iş mantığı metotları burada tanımlanabilir
        public IEnumerable<CarBrand> GetBrandsByName(string name)
        {
            return _repository.Find(brand => brand.Name.Contains(name));
        }
    }
}


