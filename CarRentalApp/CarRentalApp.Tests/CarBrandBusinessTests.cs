using CarRentalApp.Business;
using CarRentalApp.Data.Repositories;
using CarRentalApp.Entity;
using Moq;
using System.Collections.Generic;
using System.Linq;  
using Xunit;

namespace CarRentalApp.Tests
{
    public class CarBrandBusinessTests
    {
        private readonly Mock<IRepository<CarBrand>> _mockRepository;
        private readonly CarBrandBusiness _carBrandBusiness;

        public CarBrandBusinessTests()
        {
            _mockRepository = new Mock<IRepository<CarBrand>>();
            _carBrandBusiness = new CarBrandBusiness(_mockRepository.Object);
        }

        [Fact]
        public void GetAll_ShouldReturnAllCarBrands()
        {
            // Arrange
            var carBrands = new List<CarBrand>
            {
                new CarBrand { Id = 1, Name = "Brand A" },
                new CarBrand { Id = 2, Name = "Brand B" }
            };
            _mockRepository.Setup(repo => repo.GetAll()).Returns(carBrands);

            // Act
            var result = _carBrandBusiness.GetAll();

            // Assert
            Assert.Equal(2, result.Count());
            Assert.Contains(result, b => b.Name == "Brand A");
            Assert.Contains(result, b => b.Name == "Brand B");
        }
    }
}
