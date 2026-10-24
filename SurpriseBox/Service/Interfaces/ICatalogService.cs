using SurpriseBox.Models;

namespace SurpriseBox.Service.Interfaces
{
    /// <summary>
    /// Defines the service contract for loading catalog items.
    /// </summary>
    public interface ICatalogService
    {
        /// <summary>
        /// Loads all available catalog items.
        /// </summary>
        /// <returns>A list of catalog items mapped to domain models.</returns>
        List<CatalogItem> LoadCatalogItems();
    }
}