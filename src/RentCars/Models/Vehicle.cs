using RentCars.Types;
namespace RentCars.Models;

//3 - Crie a classe `Vehicle`
public class Vehicle
{
    private string _brand = "";
    private string _model = "";
    private bool _isRented = false;
    public string Brand
    {
        get { return _brand; }
        set { }
    }
    public string Model
    {
        get { return _model; }
        set { }
    }
    public decimal Price { get; set; }
    public FuelType Fuel { get; set; }
    public int EngineCapacity { get; set; }
    public Color MainColor { get; set; }
    public int Year { get; set; }
    public double PricePerDay { get; set; }
    public bool IsRented
        {
        get { return _isRented; }
        set { }
    }
}