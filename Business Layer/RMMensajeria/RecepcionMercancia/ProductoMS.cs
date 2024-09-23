namespace RMMensajeria;

public class ProductoMS
{
    public int ProductID { get; set; }

    public string ProductCode { get; set; }

    public string ProductName { get; set; }

    public string Description { get; set; }

    public string UnitOfMeasure { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public ProductoMS() { }

    public ProductoMS(int productID, string productCode, string productName, string description, string unitOfMeasure, DateTime createdAt, DateTime updatedAt)
    {
        ProductID = productID;
        ProductCode = productCode;
        ProductName = productName;
        Description = description;
        UnitOfMeasure = unitOfMeasure;
        CreatedAt = createdAt;
        UpdatedAt = updatedAt;
    }
}
