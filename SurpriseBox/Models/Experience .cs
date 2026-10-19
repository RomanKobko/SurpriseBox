using SurpriseBox.Models.Enums;

namespace SurpriseBox.Models
{
    /// <summary>
    /// Represents a service catalog item.
    /// </summary>
    public class Experience : CatalogItem
    {
        /// <summary>Duration of the experience in minutes.</summary>
        public int Duration { get; set; }

        /// <summary>
        /// Gets the catalog category of the current item.
        /// Always returns <see cref="CatalogCategory.Experience"/>.
        /// </summary>
        public override CatalogCategory CatalogCategory => CatalogCategory.Experience;
    }
}
