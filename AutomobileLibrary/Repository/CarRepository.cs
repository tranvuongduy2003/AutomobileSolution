using AutomobileLibrary.DataAccess;
using AutomobileLibrary.Repository.IRepository;

namespace AutomobileLibrary.Repository;

public class CarRepository : ICarRepository
{
    public IEnumerable<Car> GetCars() => CarManagement.Instance.GetCarList();

    public Car GetCarByID(int carId) => CarManagement.Instance.GetCarByID(carId);

    public void InsertCar(Car car) => CarManagement.Instance.AddNew(car);

    public void DeleteCar(Car car) => CarManagement.Instance.Remove(car);

    public void UpdateCar(Car car) => CarManagement.Instance.Update(car);
}