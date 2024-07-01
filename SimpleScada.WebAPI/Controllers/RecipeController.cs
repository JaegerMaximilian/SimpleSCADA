using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SimpleSCADA_Controller;
using SimpleSCADA_SharedResources;

namespace SimpleScada.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecipeController : ControllerBase
    {
        // Logger derzeit nicht nötig
        //private readonly ILogger<UserController> _logger;

        //public UserController(ILogger<UserController> logger)
        //{
        //    _logger = logger;
        //}

        [HttpGet(Name = "GetRecipe")]
        public IActionResult GetRecipe(int recipeId, bool getAll)
        {
            RecipeManager recipeManager = new RecipeManager();

            if (getAll == false)
            {
                Recipe recipeFromDb = recipeManager.GetRecipe(recipeId);

                if (recipeFromDb == null) return NotFound();

                return Ok(recipeFromDb);
            }
            else
            {
                List<Recipe> recipeFromDb = recipeManager.GetRecipes();

                if (recipeFromDb == null) return NotFound();

                return Ok(recipeManager.Recipes);
            }
        }

        [HttpPost(Name = "AddRecipe")]
        public IActionResult AddRecipe(Recipe recipe)
        {
            RecipeManager recipeManager = new RecipeManager();
            recipeManager.AddRecipe(recipe);

            return CreatedAtAction("GetRecipe", new { id = recipe.Id }, recipe);

        }

        [HttpDelete(Name = "DeleteRecipe")]
        public IActionResult DeleteRecipe(int recipeId)
        {
            RecipeManager recipeManager = new RecipeManager();
            recipeManager.RemoveRecipe(recipeId);

            if (recipeManager.Recipes.SingleOrDefault(r => r.Id == recipeId) == null)
            {
                return Ok(recipeManager.Recipes);
            }
            else
            {
                return BadRequest();
            }

        }
        [HttpPatch(Name = "EditRecipe")]
        public IActionResult EditRecipe(Recipe recipe)
        {
            RecipeManager recipeManager = new RecipeManager();
            recipeManager.EditRecipe(recipe);
            Recipe recipeFromDb = recipeManager.Recipes.SingleOrDefault(u => u.Id == recipe.Id);

            if (recipe == recipeFromDb)
            {
                return Ok(recipeManager.Recipes);
            }
            else
            {
                return BadRequest();
            }
        }


    }
}

