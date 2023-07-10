using CleanArchMvc.Domain.Validations;

namespace CleanArchMvc.Domain.Entities;

public sealed class Product : Entity
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public decimal Price { get; private set; }
    public int Stock { get; private set; }
    public string? Image { get; private set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; } = new Category("Default");

    public Product(string name, string description, decimal price, int stock, string image)
    {
        ValidationsDomain(name, description, price, stock, image);
        Name = name;
        Description = description;
        Price = price;
        Stock = stock;
        Image = image;
    }

    public Product(int id, string name, string description, decimal price, int stock, string image)
    {
        DomainExceptionValidation.When(id < 0, "Invalid id value.");
        Id = id;
        ValidationsDomain(name, description, price, stock, image);
        Name = name;
        Description = description;
        Price = price;
        Stock = stock;
        Image = image;
    }

    public void UpdateProduct(string name, string description, decimal price, int stock, string image)
    {
        ValidationsDomain(name, description, price, stock, image);
        Name = name;
        Description = description;
        Price = price;
        Stock = stock;
        Image = image;
    }

    private void ValidationsDomain(string name, string description, decimal price, int stock, string image)
    {
        DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Name is required.");
        DomainExceptionValidation.When(name.Length <= 3, "Name must be longer than 3 characters.");
        DomainExceptionValidation.When(!char.IsUpper(name[0]), "The first letter of the name must be capitalized.");

        DomainExceptionValidation.When(string.IsNullOrEmpty(description), "Description is required.");
        DomainExceptionValidation.When(description.Length <= 5, "Description must be longer than 5 characters.");
        DomainExceptionValidation.When(!char.IsUpper(description[0]), "The first letter of the description must be capitalized.");

        DomainExceptionValidation.When(price <= 0, "Value must be greater than zero.");

        DomainExceptionValidation.When(stock <= 0, "Value must be greater than zero.");

        DomainExceptionValidation.When(image.Length > 250, "Invalid image name, too long, maximum 250 caracters.");
        DomainExceptionValidation.When(!char.IsUpper(image[0]), "The first letter of the image must be capitalized.");


    }
}
