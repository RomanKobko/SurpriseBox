namespace SurpriseBox.Models
{
    /// <summary>
    /// Represents a catalog item placed in the shopping cart.
    /// </summary>
    public class CartItem
    {
        /// <summary>Gets or sets the catalog item associated with this cart entry.</summary>
        public CatalogItem CatalogItem { get; set; }
        /// <summary>Gets or sets the quantity of the catalog item in the cart.</summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Creates a new cart item for the specified catalog item
        /// and initializes its quantity to one.
        /// </summary>
        /// <param name="catalogItem">
        /// The catalog item to add to the shopping cart.
        /// </param>
        public CartItem(CatalogItem catalogItem)
        {
            CatalogItem = catalogItem;
            Quantity = 1;
        }
    }
}