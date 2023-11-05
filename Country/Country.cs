namespace Country;

/// <summary>
/// Country model.
/// </summary>
public class Country : ICountry
{
    /// <summary>
    /// Country name.
    /// </summary>
    private string _name;

    /// <summary>
    /// Count of persons which live in this country.
    /// </summary>
    private int _population;

    /// <summary>
    /// Capital city of this country.
    /// </summary>
    private PopulationCenter _capitalCity;

    /// <summary>
    /// Country's area in km^2.
    /// </summary>
    private double _area;

    /// <summary>
    /// Country's world part (Asia, Europe, ect)
    /// </summary>
    private string _worldPart;

    /// <summary>
    /// Regions of this country.
    /// </summary>
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

    public int RegionCount => _regions.Count;

    public int PopulationCenterCount => _regions.Sum((e) => e.PopulationCenterCount);

    public int Population => _regions.Sum((e) => e.Population);

    public PopulationCenter CapitalCity
    {
        get => _capitalCity;
        set => _capitalCity = value ?? throw new ArgumentNullException(nameof(value));
    }

    public double Area => _regions.Sum((e) => e.Area);

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

    //Interface implementation
    public void AddRegion(Region r)
    {
        if (r == null)
        {
            throw new ArgumentNullException();
        }

        _regions.Add(r);
    }

    public Region? FindRegionByName(string name)
    {
        return Regions.Find(e => e.Name.ToLower() == name.ToLower());
    }

    public bool DeleteRegion(Region r)
    {
        return Regions.Remove(r);
    }

    public bool DeleteRegionByName(string name)
    {
        var r = FindRegionByName(name);
        if (r == null) throw new ArgumentException("No regions with this name: " + name);
        return Regions.Remove(r);
    }
    

    public override string ToString()
    {
        string regions = "";
        if (Regions != null)
        {
            foreach (var r in Regions)
            {
                regions += r.Name + ", ";
            }

            regions = regions.Substring(0, regions.Length - 2);
        }

        return "Country name: " + Name + '\n' +
               "Capital city: " + CapitalCity.Name + '\n' +
               "Population: " + Population + '\n' +
               "World part: " + WorldPart + '\n' +
               "Area: " + Area + '\n' +
               "Regions: " + regions + '\n';
    }
}