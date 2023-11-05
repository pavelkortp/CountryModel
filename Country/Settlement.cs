﻿namespace Country;

public class Settlement: PopulationCenter
{
    public Settlement(string name) : base(name)
    {
    }

    public Settlement(string name, int population) : base(name, population)
    {
    }

    public Settlement(string name, int population, double area) : base(name, population, area)
    {
    }


}