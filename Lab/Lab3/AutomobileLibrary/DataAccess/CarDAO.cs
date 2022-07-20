using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.DataAccess
{
    public class CarDAO
    {
        private static CarDAO instance = null;
        private static readonly object instanceLock = new object();
        public static CarDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if(instance == null)
                    {
                        instance = new CarDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<Car> GetCarList()
        {
            var cars = new List<Car>();
            try
            {
                using var context = new MyStockContext();
                cars = context.Cars.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return cars;
        }

        public Car GetCarByID(int id)
        {
            Car car = null;
            try
            {
                using var context = new MyStockContext();
                car = context.Cars.SingleOrDefault(c => c.CarId == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return car;
        }

        public void AddNew(Car car)
        {
            
            try
            {
                Car carInList = GetCarByID(car.CarId);
                if (carInList == null)
                {
                    using var context = new MyStockContext();
                    context.Cars.Add(car);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Car already exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Car car)
        {

            try
            {
                Car carInList = GetCarByID(car.CarId);
                if (carInList != null)
                {
                    using var context = new MyStockContext();
                    context.Cars.Update(car);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Car not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Remove(int carId)
        {

            try
            {
                Car car = GetCarByID(carId);
                if (car != null)
                {
                    using var context = new MyStockContext();
                    context.Cars.Remove(car);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Car not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }

    
}
