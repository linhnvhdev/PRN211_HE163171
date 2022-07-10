using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomobileLibrary.BusinessObject;

namespace AutomobileLibrary.DataAccess
{
    public class CarDBContext
    {
        private static List<Car> CarList = new List<Car>()
        {
            new Car{CarID = 1, CarName = "CRV", Manufacturer = "Honda", Price = 30000, ReleaseYear = 2021},
            new Car{CarID = 2, CarName = "Ford Focus", Manufacturer = "Honda", Price = 15000, ReleaseYear = 2020}
        };
        //---------------------------------
        // Using Singleton for instance
        private static CarDBContext instance = null;
        private static readonly object instanceLock = new object();
        private CarDBContext() { }
        public static CarDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if(instance == null)
                    {
                        instance = new CarDBContext();
                    }
                    return instance;
                }
            }
        }
        //---------------------------------
        public List<Car> GetCarList => CarList;
        public Car GetCarByID(int carID)
        {
            Car car = CarList.SingleOrDefault(x => x.CarID == carID);
            return car;
        }
        // Add new car
        public void AddNew(Car car)
        {
            Car carInList = GetCarByID(car.CarID);
            if(carInList == null)
            {
                CarList.Add(car);
            }
            else
            {
                throw new Exception("Car is already exist");
            }
        }

        public void Update(Car car)
        {
            Car carInList = GetCarByID(car.CarID);
            if (carInList != null)
            {
                var index = CarList.IndexOf(carInList);
                CarList[index] = car;
            }
            else
            {
                throw new Exception("Car does not already exist");
            }
        }

        public void Remove(int carId)
        {
            Car carInList = GetCarByID(carId);
            if (carInList != null)
            {
                CarList.Remove(carInList);
            }
            else
            {
                throw new Exception("Car does not already exist");
            }
        }
    }
}
