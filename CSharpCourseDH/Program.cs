using CSharpCourseDH.FirstTask;

namespace CSharpCourseDH;

public class Program()
{

    public CVehicle _ford = new CVehicle("2141AEC341", "Ford",
        "Mustang", 1959, 800_124, true, 239.99);

    private CVehicle _bmw = new CVehicle("997319D", "BMW", "M5", 2012,
        139_932.241, false, 100.99);

    private CVehicle _audi = new CVehicle("135151FFA", "Audi", "A8",
        2023, 20_991, true, 210.42);

    private CVehicle _vw = new CVehicle("325ADFC", "Volkswagen", "Golf",
        2004, 189_351, true, 50.32);

    private CVehicle _mercedes = new CVehicle("14215FEA", "Mercedes", "CClass",
        2020, 70_431, false, 199.99);

    private List<CVehicle> _autos;

    public void InitProgram()
    {
        _autos = new List<CVehicle> { _ford, _bmw, _audi, _vw, _mercedes };

        foreach (var vehicle in _autos)
        {
            Console.WriteLine(vehicle);
            Console.WriteLine("\n");
        }
    }

    public static void Main(String[] args)
    {
        Program program = new Program();

        Console.WriteLine("The list of vehicles: \n");
        program.InitProgram();
    }

    
}

