namespace Country;

class Program
{
    static void Main()
    {
        var capital = new City(
            "Kyiv",
            10000000,
            897);
        
        var kyivObl = new Region(
            "Kyivska",
            capital
        );
        
        var kyivPopCenters = new List<PopulationCenter>();
        kyivPopCenters.Add(capital);
        kyivPopCenters.Add(new City("Boyarka", 100000, 200 ));
        kyivPopCenters.Add(new City("Irpin", 80000, 330 ));
        kyivPopCenters.Add(new City("Borispil", 70000, 400));
        kyivObl.PopulationCenters = kyivPopCenters;

        
        var regionCapitalCity = new City("Dnipro", 3000000, 900);
        var dniproObl = new Region(
            "Dniprovska",
            regionCapitalCity
        );
        
        var dniproPopCenters = new List<PopulationCenter>();
        dniproPopCenters.Add(regionCapitalCity);
        dniproPopCenters.Add(new City("Krivyi Rih", 700000, 430));
        var sofiivka = new Settlement("Sofiivka", 9000, 20);
        dniproPopCenters.Add(sofiivka);
        
        dniproObl.PopulationCenters = dniproPopCenters;

        var regions = new List<Region>();
        regions.Add(kyivObl);
        regions.Add(dniproObl);

        ICountry Ukraine = new Country(
            "Ukraine",
            capital,
            "Europe",
            regions);
        
        Console.WriteLine(Ukraine);
        
        var odeskaObl = new Region(
            "Odeska",
            regionCapitalCity
        );
        
        var odesaPopCenters = new List<PopulationCenter>();
        dniproPopCenters.Add(new City("Odesa", 2000000, 1000));
        
        odeskaObl.PopulationCenters = odesaPopCenters;

        
        Ukraine.AddRegion(odeskaObl);
        
        Console.WriteLine(Ukraine);

        Ukraine.DeleteRegion(odeskaObl);
        
        Console.WriteLine(Ukraine);
        Console.WriteLine("Count of cities: "+Ukraine.CitiesCount());
        
        sofiivka.AddResidents(15000);
        
        Console.WriteLine("Count of cities after changes: "+Ukraine.CitiesCount());

    }
}