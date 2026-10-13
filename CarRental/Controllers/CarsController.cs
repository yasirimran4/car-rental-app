using CarRental.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;

public class CarsController : Controller
{
        
    private static List<Car> _availableCars=new List<Car>([new Car(1,"Alto",3000),new Car(2,"Corolla",6000),new Car(3,"Civic",8000)]);
    private static List<Car> _bookedCars = new List<Car>();
    public ViewResult Index()
    {
        return View(_availableCars);
    }
    
    [HttpPost]
    public IActionResult Book(int Id)
    {
        Car car = _availableCars.Find(x => x.Id == Id);
        Console.WriteLine(car.Name);
        _bookedCars.Add(car);
        _availableCars.Remove(car);
        return RedirectToAction("Index");
    }

    public ViewResult Booked()
    {
        return View(_bookedCars);
    }
}
