namespace GreglistSharp.Services;
public class CarsService
{
  private readonly CarsRepository _carsRepo;

  public CarsService(CarsRepository carsRepo)
  {
    _carsRepo = carsRepo;
  }

  public List<Car> GetCars()
  {
    return _carsRepo.GetCars();
  }
  public Car CreateCar(Car carData)
  {
    return _carsRepo.CreateCar(carData);
  }

  public Car GetCar(int id)
  {
    return _carsRepo.GetCar(id);
  }

  public Car UpdateCar(Car carData, int id)
  {
    return _carsRepo.UpdateCar(carData, id);
  }
  public Car RemoveCar(int id)
  {
    Car car = GetCar(id);
    return _carsRepo.RemoveCar(id, car);
  }
}