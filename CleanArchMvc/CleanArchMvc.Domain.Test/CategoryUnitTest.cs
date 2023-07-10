using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Validations;
using FluentAssertions;

namespace CleanArchMvc.Domain.Test;

public class CategoryUnitTest
{
    [Fact(DisplayName ="Create category with paramenters valid states")]
    public void CreateCategory_WithValidParamenters_ReturnObjectValidState()
    {
        Action action = () => new Category(1, "Category");
        action.Should().NotThrow<DomainExceptionValidation>();
    }

    [Fact(DisplayName ="Create Category id negative exception invalid number")]
    public void CreateCategory_IdInvalidNumberNagetive_ExceptionInvalidNumber()
    {
        Action active = () => new Category(-1, "CategoryName");
        active.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid id value.");
    }

    [Fact(DisplayName ="Create category name is empty invalid name")]
    public void CreateCategory_NameIsEmpty_ReturnExceptionInvalidName()
    {
        Action action = () => new Category(1, "");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid name. Name is required.");
    }

    [Fact(DisplayName = "Create category short name exception name invalida")]
    public void CreateCategory_WithShortName_ExceptionNameInvalid() {
        Action action = () => new Category(1, "Cat");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid name, too short, minimum 3 characters.");
    }

    [Fact(DisplayName = "Create category name is null exception invalid name")]
    public void CreateCategory_NameNull_ExceptionInvalidName() {
        Action action = () => new Category(1, null);
        action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid name. Name is required.");
    }

    [Fact(DisplayName ="Create category not capitalized first letter exception name invalid")]
    public void CreateCategory_NotCapitalizedFirstletter_ExceptionNameInvalid()
    {
        Action action = () => new Category(1, "category");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("The first letter of the name must be capitalized.");
    }

    [Fact(DisplayName ="Update category with paramenters valid return object valid state")]
    public void UpdateCategory_WithParamenterValid_ReturnObajectValidState()
    {
        Action action = () => new Category(1, "Category").UpdateName("Caterory Update");
        action.Should().NotThrow<DomainExceptionValidation>();
    }

    [Fact(DisplayName = "Update category with paramenters valid return object valid state")]
    public void UpdateCategory_WithParamenterInValid_ExceptionInvalidName()
    {
        Action action = () => new Category(1, "Category").UpdateName("");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid name. Name is required.");
    }

    [Fact(DisplayName = "Update category short name return object valid state")]
    public void UpdateCategory_Shortname_ExceptionInvalidName()
    {
        Action action = () => new Category(1, "Category").UpdateName("Cat");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid name, too short, minimum 3 characters.");
    }

    [Fact(DisplayName = "Update category name is null return object valid state")]
    public void UpdateCategory_NameIsNull_ExceptionInvalidName()
    {
        Action action = () => new Category(1, "Category").UpdateName(null);
        action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid name. Name is required.");
    }

    [Fact(DisplayName = "Update category not capitalized first letter exception name invalid")]
    public void UpdateCategory_NotCapitalizedFirstletter_ExceptionNameInvalid()
    {
        Action action = () => new Category(1, "Category").UpdateName("category");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("The first letter of the name must be capitalized.");
    }
}