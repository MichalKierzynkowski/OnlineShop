using Application.Dto.Category;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace WebApi.Controllers
{
  public class CategoryController : BaseApiController
  {
    private readonly ICategoryService _categoryService;
    public CategoryController(ICategoryService categoryService)
    {
      _categoryService = categoryService;
    }

    [HttpGet]
    [SwaggerOperation(Summary = "Retrieves all categories")]
    public IActionResult GetAll()
    {
      var categories = _categoryService.GetAllCategories();
      return Ok(categories);
    }

    [HttpGet("{id}")]
    [SwaggerOperation(Summary = "Retrieves one category")]
    public IActionResult GetById(Guid id)
    {
      var category = _categoryService.GetCategoryById(id);
      return Ok(category);
    }

    [HttpPost]
    [SwaggerOperation(Summary = "Create new Category")]
    public IActionResult Create(CreateCategoryDto newCategory)
    {
      var id = _categoryService.AddNewCategory(newCategory);
      return Created($"api/category/{id}", newCategory);
    }
  }
}
