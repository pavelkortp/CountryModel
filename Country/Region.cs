namespace Country;

public class Region
{
    /// <summary>
    /// Region's name.
    /// </summary>
    private string _name;
    
    /// <summary>
    /// Population centers in this region.
    /// </summary>
    private List<PopulationCenter> _populationCenters;
    
    /// <summary>
    /// Count of persons, which lives in this region.
    /// </summary>
    private int _population;
    
    /// <summary>
    /// Capital city of this region.
    /// </summary>
    private PopulationCenter _regionalCentre;
    
    /// <summary>
    /// Area of region in km^2
    /// </summary>
    private double _area;
    
    

    public Region(string name)
    {
        Name = name;
    }

    public Region(string name, PopulationCenter regionalCentre) : this(name)
    {
        RegionalCentre = regionalCentre;
    }

    public Region(string name, PopulationCenter regionalCentre, List<PopulationCenter> centers) :
        this(name, regionalCentre)
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

            _populationCenters = value;
        }
    }

    public int Population => _populationCenters.Sum((e) => e.Population);
    
    public int PopulationCenterCount => _populationCenters.Count;

    public PopulationCenter RegionalCentre
    {
        get => _regionalCentre;
        set
        {
            Console.WriteLine(value);
            if (value == null)
            {
                throw new ArgumentNullException();
            }
            
            _regionalCentre = value;
        }
    }

    public double Area => _populationCenters.Sum((e) => e.Area);

    public void AddPopulationCenter(PopulationCenter p)
    {
        if (p == null)  throw new ArgumentNullException();
        this._populationCenters.Add(p);
    }

    public override bool Equals(object? obj)
    {
        if (obj is Region other)
        {
            return Name == other.Name && Area == other.Area;
        }
        return false;
    }
    

    public override string ToString()
    {
        return "Region name: " + Name + '\n' +
               "Regional center: " + RegionalCentre + '\n' +
               "Population: " + Population + '\n' +
               "Area: " + Area + '\n' +
               "Population centers: " + PopulationCenters + '\n';
    }
}