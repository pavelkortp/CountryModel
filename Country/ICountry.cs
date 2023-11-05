namespace Country;
/// <summary>
/// Country's interface.
/// </summary>
public interface ICountry
{
    /// <summary>
    /// Adds new region to country.
    /// </summary>
    /// <param name="r">new region</param>
    void AddRegion(Region r);

    /// <summary>
    /// Finds region by name and return first occurence.
    /// </summary>
    /// <param name="name">Region name</param>
    /// <returns>Found region or null</returns>
    Region? FindRegionByName(string name);

    /// <summary>
    /// Removes region from country.
    /// </summary>
    /// <param name="r">Region which need to be remove.</param>
    /// <returns>True if region removes successful, otherwise false.</returns>
    bool DeleteRegion(Region r);
    
    /// <summary>
    /// Removes region from country.
    /// </summary>
    /// <param name="name">Region's name which need to be remove.</param>
    /// <returns>True if region removes successful, otherwise false.</returns>
    bool DeleteRegionByName(string name);
}