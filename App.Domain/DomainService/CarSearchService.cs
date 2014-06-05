using System;
using System.Linq;
using App.Domain.Model;
using System.Collections.Generic;

namespace App.Domain.DomainService
{

    public interface ICarSearchService
    {
        Car GetCar(string code);

        IEnumerable<Car> Search(string request);

        IEnumerable<Car> Search();
    }

    public class CarSearchService : ICarSearchService
    {
        List<Car> thelist;

        public CarSearchService()
        {
            this.thelist = new List<Car>() {
                new Car () {
                    Id ="001",
                    Description = "une super voiture =) ",
                    Distance = 20000,
                    Year = 2001,
                    Model = "A1",
                    Brand = "Audi",
                    Fuel = "Essence",
                },
                new Car () {
                    Id ="002",
                    Description = "une super voiture =) ",
                    Distance = 323000,
                    Year = 1998,
                    Model = "classe A",
                    Brand = "Mercedes",
                    Fuel = "Gasoil",
                },
                new Car () {
                    Id ="003",
                    Description = "une super voiture =) ",
                    Distance = 120000,
                    Year = 2000,
                    Model = "Golf",
                    Brand = "volkswagen",
                    Fuel = "Essence",
                },
                new Car () {
                    Id ="004",
                    Description = "une super voiture =) ",
                    Distance = 20000,
                    Year = 2001,
                    Model = "A1",
                    Brand = "Audi",
                    Fuel = "Essence",
                },
                new Car () {
                    Id ="005",
                    Description = "une super voiture =) ",
                    Distance = 323000,
                    Year = 1998,
                    Model = "classe A",
                    Brand = "Mercedes",
                    Fuel = "Essence",
                },
                new Car () {
                    Id ="006",
                    Description = "une super voiture =) ",
                    Distance = 120000,
                    Year = 2000,
                    Model = "Golf",
                    Brand = "volkswagen",
                    Fuel = "Essence",
                },
                new Car () {
                    Id ="007",
                    Description = "une super voiture =) ",
                    Distance = 20000,
                    Year = 2001,
                    Model = "A1",
                    Brand = "Audi",
                    Fuel = "Essence",
                }
            };
        }

        public Car GetCar(string code)
        {
            return thelist.FirstOrDefault(c => c.Id == code);
        }

        public IEnumerable<Car> Search(string request)
        {
            return thelist;
        }


        public IEnumerable<Car> Search()
        {
            return thelist;
        }
    }
}

