using SurpriseBox.DataTransferObjects;
using SurpriseBox.Models;
using SurpriseBox.Models.Enums;
using SurpriseBox.Service.Interfaces;
using System.Text.Json;

namespace SurpriseBox.Service
{
    /// <summary>
    /// Service for loading catalog items from a JSON file and converting them into model classes.
    /// </summary>
    public class CatalogService : ICatalogService
    {
        // Path to the JSON file where catalog data is stored
        private readonly string _catalogItemsJsonPath = "catalogItems.json";

        /// <summary>
        /// Reads data from the file and converts it into specific model objects (Gifts or Experiences).
        /// </summary>
        /// <returns>A list of objects derived from the CatalogItem base class.</returns>
        /// <exception cref="InvalidOperationException">Thrown if the catalog category is not supported by the service.</exception>
        public List<CatalogItem> LoadCatalogItems()
        {
            if (!File.Exists(_catalogItemsJsonPath))
            {
                throw new FileNotFoundException();
            }
            // Open the file stream for reading
            using (StreamReader jsonFileReader = new StreamReader(_catalogItemsJsonPath))
            {
                // Read the entire text content of the JSON file
                string jsonContent = jsonFileReader.ReadToEnd();

                // Deserialize the text into intermediate Data Transfer Objects (DTOs)
                List<CatalogItemDto> myCatalogItemDto = JsonSerializer.Deserialize<List<CatalogItemDto>>(jsonContent) ?? new();

                // Create corresponding model objects based on the read data
                List<CatalogItem> myCatalogItem = (from catalog in myCatalogItemDto
                                                   select catalog.CatalogCategory switch
                                                   {
                                                       // Convert to Gift model
                                                       CatalogCategory.Gift => (CatalogItem)new Gift
                                                       {
                                                           Id = catalog.Id,
                                                           Name = catalog.Name,
                                                           Description = catalog.Description,
                                                           Price = catalog.Price,
                                                           SmallImagePath = catalog.SmallImagePath,
                                                           LargeImagePath = catalog.LargeImagePath,
                                                           AvailableQuantity = catalog.AvailableQuantity
                                                       },
                                                       // Convert to Experience model
                                                       CatalogCategory.Experience => (CatalogItem)new Experience
                                                       {
                                                           Id = catalog.Id,
                                                           Name = catalog.Name,
                                                           Description = catalog.Description,
                                                           Price = catalog.Price,
                                                           SmallImagePath = catalog.SmallImagePath,
                                                           LargeImagePath = catalog.LargeImagePath,
                                                           Duration = catalog.Duration
                                                       },
                                                       // If the category is unknown, throw an exception.
                                                       _ => throw new InvalidOperationException("Unknown category for model creation.")
                                                   }).ToList();

                return myCatalogItem;   //Return the complete list of converted models.
            }
        }
    }
}