using SurpriseBox.Models;

/// <summary>
/// Defines the service contract for loading catalog items.
/// </summary>
namespace SurpriseBox.Service.Interfaces
{
    public interface ICatalogService
    {
        /// <summary>
        /// Loads all available catalog items.
        /// </summary>
        /// <returns>A list of catalog items mapped to domain models.</returns>
        List<CatalogItem> LoadCatalogItems();
    }
}
