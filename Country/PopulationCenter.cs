namespace Country;

public abstract class PopulationCenter
{
    /// <summary>
    /// Name of population center.
    /// </summary>
    private string _name;
    
    /// <summary>
    /// Count of peoples.
    /// </summary>
    private int _population;

    /// <summary>
    /// Area of population center in km^2
    /// </summary>
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
        Area = area;
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

    /// <summary>
    /// Value which show how many persons on 1 km^2.
    /// </summary>
    /// <returns>population density</returns>
    public double PopulationDensity()
    {
        return Population / Area;
    }

    /// <summary>
    /// Increase population in this population center.
    /// </summary>
    /// <param name="count">number of newly arrived residents</param>
    public void AddResidents(int count)
    {
        if (count <= 0)
        {
            throw new ArgumentException("Count must be greater than zero");
        }

        Population += count;
    }

    public override bool Equals(object? obj)
    {
        if (obj is PopulationCenter other)
        {
            return Name == other.Name && Area == other.Area;
        }

        return false;
    }
    
    public override string ToString()
    {
        return "Population center name: " + Name + '\n' +
               "Population: " + Population + '\n' +
               "Area: " + Area + '\n';
    }
}