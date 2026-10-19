using SurpriseBox.Models.Enums;

namespace SurpriseBox.DataTransferObjects
{
    /// <summary>
    /// Data Transfer Object (DTO) used for reading catalog item information from a JSON file.
    /// </summary>
    public class CatalogItemDto
    {
        /// <summary>The unique identifier for the catalog item.</summary>
        public int Id { get; set; }
        /// <summary>Name of the catalog item.</summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>Detailed description of the catalog item.</summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>Price of the catalog item.</summary>
        public decimal Price { get; set; }
        /// <summary>File path to the small preview image.</summary>
        public string SmallImagePath { get; set; } = string.Empty;
        /// <summary>File path to the large full-size image.</summary>
        public string LargeImagePath { get; set; } = string.Empty;
        /// <summary>Duration of the experience in minutes.</summary>
        public int Duration { get; set; }
        /// <summary>The total available quantity of the item.</summary>
        public int AvailableQuantity { get; set; }
        /// <summary>Gets or sets the category this catalog item belongs to.</summary>
        public CatalogCategory CatalogCategory { get; set; }
    }
}