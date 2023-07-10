using CleanArchMvc.Domain.Validations;
using System.Collections.Generic;

namespace CleanArchMvc.Domain.Entities;

public sealed class Category : Entity
{
    public string Name { get; private set; }

    public ICollection<Product> Products { get; set; } = new List<Product>();

    public Category(string name)
    {
        ValidateDomain(name);
        Name = name;
    }

    public Category(int id, string name)
    {
        DomainExceptionValidation.When(id < 0, "Invalid Id value.");
        Id = id;
        ValidateDomain(name);
        Name = name;
    }

    public void UpdateName(string name)
    {
        ValidateDomain(name);
        Name = name;
    }

    private void ValidateDomain(string name)
    {
        DomainExceptionValidation.When(string.IsNullOrEmpty(name),
            "Invalid name. Name is required.");

        DomainExceptionValidation.When(name.Length <= 3,
            "Invalid name, too short, minimum 3 characters.");

        DomainExceptionValidation.When(!char.IsUpper(name[0]), 
            "The first letter of the name must be capitalized.");
    }
}
