using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Validations;
using FluentAssertions;

namespace CleanArchMvc.Domain.Test;

public class ProductUnitTest
{

    [Fact(DisplayName = "Create Product with paramenters valid return object valid state")]
    public void CreateProduct_WithParamentersValid_ReturnObjectValidState()
    {
        Action action = () => new Product(1, "Lapis", "Lapis Preto", 1.0m, 50, "Lapis.jpg");
        action.Should().NotThrow<DomainExceptionValidation>();
    }

    [Fact(DisplayName = "Create Product invalid id negative return exception invalid Id")]
    public void CreateProduct_invalidIdNegative_ExceptionIndalidId()
    {
        Action action = () => new Product(-1, "Lapis", "Lapis Preto", 1.0m, 50, "lapis.jpg");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid id value.");
    }

    [Fact(DisplayName = "Create Product name is empty invalid name")]
    public void CreateProduct_NameIsEmpty_ReturnExceptionInvalidName()
    {
        Action action = () => new Product(1, "", "Lapis preto", 1.00m, 10, "Lapis.jpg");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("Name is required.");
    }

    [Fact(DisplayName = "Create Product short name exception name invalida")]
    public void CreateProduct_WithShortName_ExceptionNameInvalid()
    {
        Action action = () => new Product(1, "Lap", "Lapis preto", 1.00m, 10, "Lapis.jpg");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("Name must be longer than 3 characters.");
    }

    [Fact(DisplayName = "Create Product name is null exception invalid name")]
    public void CreateProduct_NameNull_ExceptionInvalidName()
    {
        Action action = () => new Product(1, null, "Lapis preto", 1.00m, 10, "Lapis.jpg");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("Name is required.");
    }

    [Fact(DisplayName = "Create Product not capitalized first letter exception name invalid")]
    public void CreateProduct_NotCapitalizedFirstletter_ExceptionNameInvalid()
    {
        Action action = () => new Product(1, "lapis", "Lapis preto", 1.00m, 10, "lapis.jpg");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("The first letter of the name must be capitalized.");
    }


    [Fact(DisplayName = "Create Product description is empty invalid name")]
    public void CreateProduct_DescriptionIsEmpty_ReturnExceptionInvalidDescription()
    {
        Action action = () => new Product(1, "Lapis", "", 1.00m, 10, "Lapis.jpg");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("Description is required.");
    }

    [Fact(DisplayName = "Create Product short name description exception name invalida")]
    public void CreateProduct_WithShortNameDescription_ExceptionNameInvalid()
    {
        Action action = () => new Product(1, "Lapis", "Lap", 1.00m, 10, "Lapis.jpg");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("Description must be longer than 5 characters.");
    }

    [Fact(DisplayName = "Create Product description is null exception invalid name")]
    public void CreateProduct_DescriptionNull_ExceptionInvalidName()
    {
        Action action = () => new Product(1, "Lapis", null, 1.00m, 10, "Lapis.jpg");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("Description is required.");
    }

    [Fact(DisplayName = "Create Product not capitalized first letter exception name description invalid")]
    public void CreateProduct_NotCapitalizedFirstletter_ExceptionDescriptionInvalid()
    {
        Action action = () => new Product(1, "Lapis", "lapis preto", 1.00m, 10, "lapis.jpg");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("The first letter of the description must be capitalized.");
    }

    [Fact(DisplayName = "Create Product price negative number invalid value")]
    public void CreateProduct_PriceNumberNegative_ReturnExceptionInvalidValue()
    {
        Action action = () => new Product(1, "Lapis", "Lapis preto", -1.00m, 10, "Lapis.jpg");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("value must be greater than zero.");
    }

    [Fact(DisplayName = "Create Product stock negative number invalid value")]
    public void CreateProduct_StockNumberNegative_ReturnExceptionInvalidValue()
    {
        Action action = () => new Product(1, "Lapis", "Lapis preto", 1.00m, -10, "Lapis.jpg");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("value must be greater than zero.");
    }

    [Fact(DisplayName = "Create Product image is null valid state ")]
    public void CreateProduct_ImageNull_ReturnObjectvalidState()
    {
        Action action = () => new Product(1, "Lapis", "Lapis preto", 1.00m, 10, null);
        action.Should().NotThrow<DomainExceptionValidation>();
    }

    [Fact(DisplayName = "Create Product not capitalized first letter exception image description invalid")]
    public void CreateProduct_NotCapitalizedFirstletter_ExceptionImageInvalid()
    {
        Action action = () => new Product(1, "Lapis", "Lapis preto", 1.00m, 10, "lapis.jpg");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("The first letter of the image must be capitalized.");
    }

    [Fact(DisplayName = "Create Product long name image exception invalid")]
    public void CreateProduct_LongNameImage_ExceptionDescriptionInvalid()
    {
        Action action = () => new Product(1, "Lapis", "Lapis preto", 1.00m, 10
            , "Imaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaagem");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid image name, too long, maximum 250 caracters.");
    }

    [Fact(DisplayName = "Update Product with paramenters valid return object valid state")]
    public void UpdateProduct_WithParamenterValid_ReturnObjectValidState()
    {
        Action action = () => new Product(1, "Lapis", "Lapis Preto", 1.0m, 50, "Lapis.jpg").UpdateProduct("Lapis", "Lapis Preto", 1.0m, 50, "Lapis.jpg");
        action.Should().NotThrow<DomainExceptionValidation>();
    }

    [Fact(DisplayName = "Update Product with paramenters valid return object valid state")]
    public void UpdateProduct_WithParamenterInValid_ExceptionInvalidName()
    {
        Action action = () => new Product(1, "Lapis", "Lapis Preto", 1.0m, 50, "Lapis.jpg").UpdateProduct("", "Lapis Preto", 1.0m, 50, "Lapis.jpg");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("Name is required.");
    }

    [Fact(DisplayName = "Update Product short name return object valid state")]
    public void UpdateProduct_Shortname_ExceptionInvalidName()
    {
        Action action = () => new Product(1, "Lapis", "Lapis Preto", 1.0m, 50, "Lapis.jpg").UpdateProduct("Lap", "Lapis Preto", 1.0m, 50, "Lapis.jpg");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("Name must be longer than 3 characters.");
    }

    [Fact(DisplayName = "Update Product name is null return object valid state")]
    public void UpdateProduct_NameIsNull_ExceptionInvalidName()
    {
        Action action = () => new Product(1, "Lapis", "Lapis Preto", 1.0m, 50, "Lapis.jpg").UpdateProduct(null, "Lapis Preto", 1.0m, 50, "Lapis.jpg");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("Name is required.");
    }

    [Fact(DisplayName = "Update Product not capitalized first letter exception name invalid")]
    public void UpdateProduct_NotCapitalizedFirstletter_ExceptionNameInvalid()
    {
        Action action = () => new Product(1, "Lapis", "Lapis Preto", 1.0m, 50, "Lapis.jpg").UpdateProduct("lapis", "Lapis Preto", 1.0m, 50, "Lapis.jpg");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("The first letter of the name must be capitalized.");
    }


    [Fact(DisplayName = "Update Product with paramenters description invalid return object invalid state")]
    public void UpdateProduct_WithParamenterInValid_ExceptionInvalidDescription()
    {
        Action action = () => new Product(1, "Lapis", "Lapis Preto", 1.0m, 50, "Lapis.jpg").UpdateProduct("Lapis", "", 1.0m, 50, "Lapis.jpg");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("Description is required.");
    }

    [Fact(DisplayName = "Update Product short desctiption return object invalid state")]
    public void UpdateProduct_ShortDescription_ExceptionInvalidDescription()
    {
        Action action = () => new Product(1, "Lapis", "Lapis Preto", 1.0m, 50, "Lapis.jpg").UpdateProduct("Lapis", "Lapi", 1.0m, 50, "Lapis.jpg");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("Description must be longer than 5 characters.");
    }

    [Fact(DisplayName = "Update Product description is null return object invalid state")]
    public void UpdateProduct_DescriptionIsNull_ExceptionInvalidName()
    {
        Action action = () => new Product(1, "Lapis", "Lapis Preto", 1.0m, 50, "Lapis.jpg").UpdateProduct("Lapis", null, 1.0m, 50, "Lapis.jpg");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("Description is required.");
    }

    [Fact(DisplayName = "Update Product not capitalized first letter exception description invalid")]
    public void UpdateProduct_NotCapitalizedFirstletter_ExceptionDescriptionInvalid()
    {
        Action action = () => new Product(1, "Lapis", "Lapis Preto", 1.0m, 50, "Lapis.jpg").UpdateProduct("Lapis", "lapis Preto", 1.0m, 50, "Lapis.jpg");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("The first letter of the description must be capitalized.");
    }

    [Fact(DisplayName = "Update Product price negative number invalid value")]
    public void UpdateProduct_PriceNumberNegative_ReturnExceptionInvalidValue()
    {
        Action action = () => new Product(1, "Lapis", "Lapis preto", 1.00m, 10, "Lapis.jpg").UpdateProduct("Lapis", "Lapis preto", -1.00m, 10, "Lapis.jpg");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("value must be greater than zero.");
    }

    [Fact(DisplayName = "Update Product stock negative number invalid value")]
    public void UpdateProduct_StrockNumberNegative_ReturnExceptionInvalidValue()
    {
        Action action = () => new Product(1, "Lapis", "Lapis preto", 1.00m, 10, "Lapis.jpg").UpdateProduct("Lapis", "Lapis preto", 1.00m, -10, "Lapis.jpg");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("value must be greater than zero.");
    }

    [Fact(DisplayName = "Update Product image is null valid state ")]
    public void UpdateProduct_ImageNull_ReturnObjectvalidState()
    {
        Action action = () => new Product(1, "Lapis", "Lapis preto", 1.00m, 10, "Imagem Lapis.jpg").UpdateProduct("Lapis", "Lapis preto", 1.00m, 10, null);
        action.Should().NotThrow<DomainExceptionValidation>();
    }

    [Fact(DisplayName = "Update Productnot capitalized first letter exception image description invalid")]
    public void UpdateProduct_NotCapitalizedFirstletter_ExceptionImageInvalid()
    {
        Action action = () => new Product(1, "Lapis", "Lapis preto", 1.00m, 10, "Imagem Lapis.jpg").UpdateProduct("Lapis", "Lapis preto", 1.00m, 10, "lapis.jpg");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("The first letter of the image must be capitalized.");
    }

    [Fact(DisplayName = "Update Product long name image exception invalid")]
    public void UpdateProduct_LongNameImage_ExceptionInvalid()
    {
        Action action = () => new Product(1, "Lapis", "Lapis preto", 1.00m, 10, "Imagem Lapis.jpg").UpdateProduct("Lapis", "Lapis preto", 1.00m, 10, "Imaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaagem");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid image name, too long, maximum 250 caracters.");
    }
}
