namespace Country;

public class City: PopulationCenter
{
    public City(string name) : base(name)
    {
    }

    public City(string name, int population) : base(name, population)
    {
    }

    public City(string name, int population, double area) : base(name, population, area)
    {
    }

    public City(string name, int population, double area, Region region) : base(name, population, area, region)
    {
    }
}