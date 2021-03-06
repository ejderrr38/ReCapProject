﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=100,ColorId=50,ModelYear=2016,DailyPrice=5000000,Description="Honda Civic sports"},
                new Car{CarId=2,BrandId=101,ColorId=51,ModelYear=2017,DailyPrice=6000000,Description="Bmw"},
                new Car{CarId=3,BrandId=102,ColorId=52,ModelYear=2018,DailyPrice=7000000,Description="Hyundai"},
                new Car{CarId=5,BrandId=104,ColorId=54,ModelYear=2020,DailyPrice=9000000,Description="Volkswagen"}
            };
        }
       
            
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p =>p.CarId == car.CarId);
            _cars.Remove(carToDelete);

            
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllById(int brandId)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByAllId(int brandId)
        {
            return _cars.Where(p => p.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
