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
    
    public override string ToString()
    {
        return "Population center name: " + Name + '\n' +
               "Population: " + Population + '\n' +
               "Area: " + Area + '\n';
    }
}