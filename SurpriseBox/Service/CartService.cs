using SurpriseBox.Models;
using SurpriseBox.Service.Interfaces;
using System.Text.Json;

namespace SurpriseBox.Service
{
    /// <summary>
    /// Service for loading cart items from a JSON file and converting them into model classes.
    /// </summary>
    public class CartService : ICartService
    {
        // Path to the JSON file where cart data is stored
        private readonly string _cartItemsJsonPath = "cartItems.json";

        /// <summary>
        /// Loads all cart items from the JSON file and maps them to domain models.
        /// </summary>
        /// <returns>
        /// A list of cart items containing catalog item information and quantities.
        /// </returns>
        public List<CartItem> LoadCartItems()
        {
            CheckCartFileExists();

            // Service used to load catalog data and resolve item identifiers
            ICatalogService catalogService = new CatalogService();

            // Collection of all available catalog items
            List<CatalogItem> catalogItems = catalogService.LoadCatalogItems();

            // Open the file stream for reading
            using (StreamReader jsonFileReader = new StreamReader(_cartItemsJsonPath))
            {
                // Read the entire text content of the JSON file
                string jsonCartContent = jsonFileReader.ReadToEnd();

                // Return an empty collection if the file contains no data
                if (string.IsNullOrWhiteSpace(jsonCartContent))
                {
                    return new List<CartItem>();
                }
                else
                {
                    // Deserialize the text into intermediate Data Transfer Objects (DTOs)
                    List<CartItemDto> cartItemDto =
                        JsonSerializer.Deserialize<List<CartItemDto>>(jsonCartContent) ?? new();

                    // Match cart records with catalog items and create domain objects
                    List<CartItem> cartItems =
                        (from cart in cartItemDto
                         join catalog in catalogItems
                         on cart.CatalogItemId equals catalog.Id
                         select new CartItem(catalog)
                         {
                             Quantity = cart.Quantity
                         }).ToList();

                    return cartItems;
                }
            }
        }

        /// <summary>
        /// Adds an item to the shopping cart.
        /// If the item already exists, its quantity is increased.
        /// Otherwise a new cart entry is created.
        /// </summary>
        /// <param name="item">The cart item to add.</param>
        public void AddCartItems(CartItem item)
        {
            CheckCartFileExists();

            // Collection that will be saved back to the JSON file
            List<CartItemDto> cartItemDto = new List<CartItemDto>();

            // Current cart state
            List<CartItem> cartItems = LoadCartItems();

            // Indicates whether the item already exists in the cart
            bool itemExists = false;

            foreach (var currentItem in cartItems)
            {
                // Increase quantity if the item already exists
                if (currentItem.CatalogItem.Id == item.CatalogItem.Id)
                {
                    currentItem.Quantity++;
                    itemExists = true;
                }

                // Convert domain model back into DTO format
                cartItemDto.Add(new CartItemDto
                {
                    CatalogItemId = currentItem.CatalogItem.Id,
                    Quantity = currentItem.Quantity
                });
            }

            // Add a new record if the item was not found in the cart
            if (!itemExists)
            {
                cartItemDto.Add(new CartItemDto
                {
                    CatalogItemId = item.CatalogItem.Id,
                    Quantity = item.Quantity
                });
            }

            SaveCartItems(cartItemDto);
        }

        /// <summary>
        /// Removes all quantities of the specified item from the shopping cart.
        /// </summary>
        /// <param name="item">The cart item to remove.</param>
        public void RemoveCartItems(CartItem item)
        {
            CheckCartFileExists();

            // Collection that will be saved back to the JSON file
            List<CartItemDto> cartItemDto = new List<CartItemDto>();

            // Current cart state
            List<CartItem> cartItems = LoadCartItems();

            // Iterate backwards to safely remove matching elements
            for (int i = cartItems.Count - 1; i >= 0; i--)
            {
                // Remove all entries matching the given catalog item
                if (cartItems[i].CatalogItem.Id == item.CatalogItem.Id)
                {
                    cartItems.RemoveAt(i);
                }
                else
                {
                    // Preserve all other items
                    cartItemDto.Add(new CartItemDto
                    {
                        CatalogItemId = cartItems[i].CatalogItem.Id,
                        Quantity = cartItems[i].Quantity
                    });
                }
            }

            SaveCartItems(cartItemDto);
        }

        /// <summary>
        /// Removes all items from the shopping cart.
        /// </summary>
        public void RemoveAllCartItems()
        {
            CheckCartFileExists();

            // Clear the cart file content completely
            using (StreamWriter jsonFileWriter = new StreamWriter(_cartItemsJsonPath))
            {
                jsonFileWriter.Write(string.Empty);
            }
        }

        /// <summary>
        /// Decreases the quantity of the specified item in the shopping cart by one.
        /// The quantity cannot become less than one.
        /// </summary>
        /// <param name="item">
        /// The cart item whose quantity should be decreased.
        /// </param>
        public void DecreaseItemQuantity(CartItem item)
        {
            CheckCartFileExists();

            // Collection that will be saved back to the JSON file
            List<CartItemDto> cartItemDto = new List<CartItemDto>();

            // Current cart state
            List<CartItem> cartItems = LoadCartItems();

            foreach (var currentItem in cartItems)
            {
                // Find the required item and decrease its quantity
                if (currentItem.CatalogItem.Id == item.CatalogItem.Id)
                {
                    if (currentItem.Quantity > 1)
                    {
                        currentItem.Quantity--;
                    }
                }

                // Convert domain model back into DTO format
                cartItemDto.Add(new CartItemDto
                {
                    CatalogItemId = currentItem.CatalogItem.Id,
                    Quantity = currentItem.Quantity
                });
            }

            SaveCartItems(cartItemDto);
        }

        /// <summary>
        /// Serializes cart item DTOs and writes them into the cart JSON file.
        /// </summary>
        /// <param name="cartItemDto">
        /// Collection of cart item DTOs to be saved.
        /// </param>
        private void SaveCartItems(List<CartItemDto> cartItemDto)
        {
            // Configure JSON formatting
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            // Convert collection into JSON representation
            string jsonCartContent =
                JsonSerializer.Serialize(cartItemDto, options);

            // Save JSON data to the file
            using (StreamWriter jsonFileWritter = new StreamWriter(_cartItemsJsonPath))
            {
                jsonFileWritter.Write(jsonCartContent);
            }
        }

        /// <summary>
        /// Verifies that the shopping cart JSON file exists.
        /// </summary>
        /// <exception cref="FileNotFoundException">
        /// Thrown when the cart JSON file cannot be found.
        /// </exception>
        private void CheckCartFileExists()
        {
            if (!File.Exists(_cartItemsJsonPath))
            {
                throw new FileNotFoundException(
                    $"Cart file not found: {_cartItemsJsonPath}");
            }
        }
    }
}