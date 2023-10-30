namespace Country;

public class Region
{
    private string _name;
    private List<PopulationCenter> _populationCenters;
    private int _population;
    private PopulationCenter _regionalCentre;
    private double _area;
    private Country _country;

    public Region(string name)
    {
        Name = name;
    }

    public Region(string name, Country country) : this(name)
    {
        Name = name;
        Country = country;
    }

    public Region(string name, Country country, PopulationCenter regionalCentre) : this(name, country)
    {
        RegionalCentre = regionalCentre;
    }

    public Region(string name, Country country, PopulationCenter regionalCentre, List<PopulationCenter> centers) :
        this(name, country, regionalCentre)
    {
        PopulationCenters = centers;
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

    public List<PopulationCenter> PopulationCenters
    {
        get => _populationCenters;
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException();
            }

            _populationCenters = value
                .Where((e) => !e.Region.Equals(this))
                .Select((c) =>
                {
                    c.Region = this;
                    return c;
                })
                .ToList();
        }
    }

    public int Population => _populationCenters.Sum((e) => e.Population);

    public Country Country
    {
        get => _country;
        set => _country = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int PopulationCenterCount => _populationCenters.Capacity;

    public PopulationCenter RegionalCentre
    {
        get => _regionalCentre;
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException();
            }

            if (!_populationCenters.Contains(value))
            {
                _populationCenters.Add(value);
            }

            _regionalCentre = value;
        }
    }

    public double Area => _populationCenters.Sum((e) => e.Area);

    public override bool Equals(object? obj)
    {
        if (obj is Region other)
        {
            return Name.ToLower().Equals(other.Name.ToLower()) &&
                   Country.Equals(Country);
        }

        return false;
    }

    public override int GetHashCode()
    {
        return Name.GetHashCode();
    }
    
    public static bool operator ==(Region left, Region right)
    {
        if (ReferenceEquals(left, null) && ReferenceEquals(right, null))
            return true;

        if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
            return false;
        return left.Equals(right);
    }

    public static bool operator !=(Region left, Region right)
    {
        return !(left == right);
    }
}