namespace Country;

public abstract class PopulationCenter
{   
    //Name of population center.
    private string _name;
    //Region in which PopulationCenter placed
    private Region _region;
    //Count of peoples.
    private int _population;
    //Area of population center in km^2
    private double _area;

    public PopulationCenter(string name)
    {
        Name = name;
    }

    public PopulationCenter(string name, int population) : this(name)
    {
        Population = population;
    }

    public PopulationCenter(string name, int population, double area) : this(name, population)
    {
        Area = population;
    }

    public PopulationCenter(string name, int population, double area, Region region) : this(name, population, area)
    {
        Region = region;
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

    public Region Region
    {
        get => _region;
        set => _region = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Population
    {
        get => _population;
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Population must be greater then zero");
            }

            _population = value;
        }
    }

    public double Area
    {
        get => _area;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Population must be greater then zero");
            }

            _area = value;
        }
    }
}