﻿using AutomobileLibrary.DataAccess;

namespace AutomobileLibrary.Repository.IRepository;

public interface ICarRepository
{
    IEnumerable<Car> GetCars();
    Car GetCarByID(int carId);
    void InsertCar(Car car);
    void DeleteCar(Car car);
    void UpdateCar(Car car);
}