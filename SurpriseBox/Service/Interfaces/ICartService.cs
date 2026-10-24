using SurpriseBox.Models;

namespace SurpriseBox.Service.Interfaces
{
    /// <summary>
    /// Defines the service contract for loading cart items.
    /// </summary>
    public interface ICartService
    {
        /// <summary>
        /// Loads all available cart items.
        /// </summary>
        /// <returns>A list of cart items mapped to domain models.</returns>
        List<CartItem> LoadCartItems();

        /// <summary>
        /// Adds an item to the shopping cart.
        /// If the item already exists, its quantity is increased.
        /// </summary>
        /// <param name="item">The cart item to add.</param>
        void AddCartItems(CartItem item);

        /// <summary>
        /// Removes the specified item and all of its quantities from the shopping cart.
        /// </summary>
        /// <param name="item">The cart item to remove.</param>
        void RemoveCartItems(CartItem item);

        /// <summary>
        /// Removes all items from the shopping cart.
        /// </summary>
        void RemoveAllCartItems();

        /// <summary>
        /// Decreases the quantity of the specified cart item by one.
        /// </summary>
        /// <param name="item">The cart item whose quantity should be decreased.</param>
        void DecreaseItemQuantity(CartItem item);
    }
}