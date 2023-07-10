using CleanArchMvc.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchMvc.Web.UI.Controllers;

public class CategoriesController : Controller
{
    private readonly ICategoryService _categorySevice;

    public CategoriesController(ICategoryService categoryService)
    {
        _categorySevice = categoryService;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var result = await _categorySevice.GetCategoriesDTOAsync();
        return View(result);
    }
}
