using CarRental.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;

public class CarsController : Controller
{
    private static List<Car> availableCars;
    private static List<Car> bookedCars;

    CarsController()
    {
        Car car1 = new Car(1,"Alto",3000);
        Car car2 = new Car(2,"Corolla",6000);
        Car car3 = new Car(3,"Civic",8000);
        availableCars.Add(car1);
        availableCars.Add(car2);
        availableCars.Add(car3);
        bookedCars = new List<Car>();
    }
    
    
}