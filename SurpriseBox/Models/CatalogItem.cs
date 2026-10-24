using SurpriseBox.Models.Enums;

namespace SurpriseBox.Models
{
    /// <summary>
    /// Base abstract class for all catalog items.
    /// </summary>
    public abstract class CatalogItem
    {
        /// <summary>Unique identifier of the item.</summary>
        public int Id { get; set; }
        /// <summary>Name of the catalog item.</summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>Detailed description of the item.</summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>Cost of the item.</summary>
        public decimal Price { get; set; }
        /// <summary>Path to the small thumbnail image for the catalog list.</summary>
        public string SmallImagePath { get; set; } = string.Empty;
        /// <summary>Path to the large full-size image for the details page.</summary>
        public string LargeImagePath { get; set; } = string.Empty;

        /// <summary>Gets the category of the current catalog item.</summary>
        public abstract CatalogCategory CatalogCategory { get; }
    }
}
