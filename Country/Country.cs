namespace Country;

public class Country
{
    private string _name;
    private int _population;
    private PopulationCenter _capitalCity;
    private double _area;
    private string _worldPart;
    private List<Region> _regions;

    public Country(string name)
    {
        Name = name;
    }

    public Country(string name, PopulationCenter capital) : this(name)
    {
        CapitalCity = capital;
    }
    
    public Country(string name, PopulationCenter capital, string worldPart) : this(name, capital)
    {
        WorldPart = worldPart;
    }

    public Country(string name, PopulationCenter capital, string worldPart, List<Region> regions) : 
        this(name, capital, worldPart)
    {
        Regions = regions;
    }
    
    public string Name
    {
        get => _name;
        set
        {
            if (value == "")
            {
                throw new ArgumentException("Name must be not empty");
            }

            _name = value;
        }
    }

    public int RegionCount => _regions.Capacity;

    public int PopulationCenterCount => _regions.Sum((e)=> e.PopulationCenterCount);

    public int Population => _regions.Sum((e) => e.Population);

    public PopulationCenter CapitalCity
    {
        get => _capitalCity;
        set => _capitalCity = value ?? throw new ArgumentNullException(nameof(value));
    }

    public double Area => _regions.Sum((e)=> e.Area);

    public string WorldPart
    {
        get => _worldPart;
        set
        {
            if (value == "")
            {
                throw new ArgumentException("World part name must be not empty");
            }

            _worldPart = value;
        }
    }

    public List<Region> Regions
    {
        get => _regions;
        set => _regions = value ?? throw new ArgumentNullException(nameof(value));
    }
    
}