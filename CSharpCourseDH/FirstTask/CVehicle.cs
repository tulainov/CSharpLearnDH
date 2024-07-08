namespace CSharpCourseDH.FirstTask;

/// <summary>
/// The CVehicle class with private fields and CalculateRentalCost() method
/// </summary>


public class CVehicle
{
    private string _id;
    private string _manufacturer;
    private string _model;
    private int _year;
    private double _mileage;
    private bool _availability;
    private double _rentalCostPerDay;

    public CVehicle(string id, string manufacturer, string model, int year,
        double mileage, bool availability, double rentalCostPerDay)
    {
        _id = id;
        _manufacturer = manufacturer;
        _model = model;
        _year = year;
        _mileage = mileage;
        _availability = availability;
        _rentalCostPerDay = rentalCostPerDay;
    }

    public double CalculateRentalCost(int days)
    {
        return _rentalCostPerDay * days;
    }

    public override string ToString()
    {
        return $"Car id: {_id}\n" +
               $"Manufacturer: {_manufacturer}\n" +
               $"Model: {_model}\n" +
               $"Year: {_year}\n" +
               $"Mileage: {_mileage}\n" +
               $"Availability: {_availability}\n" +
               $"Cost per day: {_rentalCostPerDay}";
    }

    public string Id
    {
        get => _id;
        set => _id = value;
    }

    public string Manufacturer
    {
        get => _manufacturer;
        set => _manufacturer = value;
    }

    public string Model
    {
        get => _model;
        set => _model = value;
    }

    public int Year
    {
        get => _year;
        set => _year = value;
    }
    
    public double Mileage
    {
        get => _mileage;
        set => _mileage = value;
    }

    public bool Availability
    {
        get => _availability;
        set => _availability = value;
    }

    public double RentalCostPerDay
    {
        get => _rentalCostPerDay;
        set => _rentalCostPerDay = value;
    }
}