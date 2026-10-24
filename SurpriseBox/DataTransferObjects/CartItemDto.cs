/// <summary>
/// Data Transfer Object (DTO) used for reading shopping cart data from a JSON file.
/// </summary>
public class CartItemDto
{
    /// <summary>
    /// Identifier of the catalog item stored in the shopping cart.
    /// </summary>
    public int CatalogItemId { get; set; }

    /// <summary>
    /// Quantity of the catalog item in the shopping cart.
    /// </summary>
    public int Quantity { get; set; }
}