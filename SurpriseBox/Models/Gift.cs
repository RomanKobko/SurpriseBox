using SurpriseBox.Models.Enums;

namespace SurpriseBox.Models
{
    /// <summary>
    /// Represents a product catalog item.
    /// </summary>
    public class Gift : CatalogItem
    {
        /// <summary>The total available quantity of the item.</summary>
        public int AvailableQuantity { get; set; }

        /// <summary>
        /// Gets the catalog category of the current item.
        /// Always returns <see cref="CatalogCategory.Gift"/>.
        /// </summary>
        public override CatalogCategory CatalogCategory => CatalogCategory.Gift;
    }
}