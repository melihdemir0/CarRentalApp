using CarRentalApp.Business;
using CarRentalApp.Data.Repositories;
using CarRentalApp.Entity;
using Moq;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace CarRentalApp.Tests
{
    public class CarBusinessTests
    {
        private readonly Mock<IRepository<Car>> _mockRepository;
        private readonly CarBusiness _carBusiness;

        public CarBusinessTests()
        {
            _mockRepository = new Mock<IRepository<Car>>();
            _carBusiness = new CarBusiness(_mockRepository.Object);
        }

        [Fact]
        public void GetAll_ShouldReturnAllCars()
        {
            // Arrange
            var cars = new List<Car>
            {
                new Car { Id = 1, Model = "Model X" },
                new Car { Id = 2, Model = "Model Y" }
            };
            _mockRepository.Setup(repo => repo.GetAll()).Returns(cars);

            // Act
            var result = _carBusiness.GetAll();

            // Assert
            Assert.Equal(2, result.Count());
            Assert.Contains(result, c => c.Model == "Model X");
            Assert.Contains(result, c => c.Model == "Model Y");
        }

        [Fact]
        public void GetById_ShouldReturnCarWithGivenId()
        {
            // Arrange
            var car = new Car { Id = 1, Model = "Model X" };
            _mockRepository.Setup(repo => repo.GetById(1)).Returns(car);

            // Act
            var result = _carBusiness.GetById(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Model X", result.Model);
        }

        [Fact]
        public void Add_ShouldAddNewCar()
        {
            // Arrange
            var car = new Car { Id = 1, Model = "Model X" };

            // Act
            _carBusiness.Add(car);

            // Assert
            _mockRepository.Verify(repo => repo.Add(It.IsAny<Car>()), Times.Once);
        }

        [Fact]
        public void Update_ShouldUpdateExistingCar()
        {
            // Arrange
            var car = new Car { Id = 1, Model = "Model X" };

            // Act
            _carBusiness.Update(car);

            // Assert
            _mockRepository.Verify(repo => repo.Update(It.IsAny<Car>()), Times.Once);
        }

        [Fact]
        public void Delete_ShouldRemoveCar()
        {
            // Act
            _carBusiness.Delete(1);

            // Assert
            _mockRepository.Verify(repo => repo.Remove(It.IsAny<Car>()), Times.Once);
        }
    }
}
