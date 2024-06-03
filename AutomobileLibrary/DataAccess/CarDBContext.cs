using AutomobileLibrary.BussinessObject;

namespace AutomobileLibrary.DataAccess;

public class CarDBContext
{
    private static List<Car> CarList = new List<Car>
    {
        new() {CarID = 1, CarName = "CRV", Manufacturer = "Honda", Price = 30000, ReleaseYear = 2021},
        new() {CarID = 2, CarName = "Ford Focus", Manufacturer = "Ford", Price = 15000, ReleaseYear = 2020}
    };

    private static CarDBContext instance = null;
    private static readonly object instanceLock = new object();
    private CarDBContext() { }
    public static CarDBContext Instance
    {
        get
        {
            lock (instanceLock)
            {
                if (instance == null)
                {
                    instance = new CarDBContext();
                }
                return instance;
            }
        }
    }

    public List<Car> GetCarList => CarList;
    
    public Car? GetCarByID(int carID) => CarList.FirstOrDefault(c => c.CarID == carID); 
    
    public void AddNew(Car car)
    {
        var c = GetCarByID(car.CarID);
        if (c == null)
        {
            CarList.Add(car);
        }
        else
        {
            throw new Exception("Car is already exists.");
        } 
    }

    public void Update(Car car)
    {
        var c = GetCarByID(car.CarID);
        if (c != null)
        {
            CarList[CarList.IndexOf(c)] = car;
        }
        else
        {
            throw new Exception("Car does not already exists.");
        }
    }

    public void Remove(int carID)
    {
        var c = GetCarByID(carID);
        if (c != null)
        {
            CarList.Remove(c);
        }
        else
        {
            throw new Exception("Car does not already exists.");
        }
    }
}