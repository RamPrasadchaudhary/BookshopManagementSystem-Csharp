public class Product
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Genre { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }

    public Product(int id, string name, string genre, int quantity, decimal price)
    {
        ID = id;
        Name = name;
        Genre = genre;
        Quantity = quantity;
        Price = price;
    }

    public override string ToString()
    {
        return $"ID: {ID}, Name: {Name}, Genre: {Genre}, Quantity: {Quantity}, Price: {Price:C}";
    }
}
