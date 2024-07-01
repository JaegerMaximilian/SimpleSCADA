using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SimpleScada.WebAPI.Filters;
using SimpleSCADA_Controller;
using SimpleSCADA_SharedResources;

namespace SimpleScada.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    //[ApiKeyAuth]
    public class UserController : ControllerBase
    {
        
        [HttpGet(Name = "GetUser")]
        public IActionResult GetUser(int id,bool getAll)
        {
            UserManager userManager = new UserManager();

            if (getAll == false)
            {
                User userFromDb = userManager.GetUser(id);

                if (userFromDb == null) return NotFound();

                return Ok(userFromDb);
            }
            else
            {
                List<User> usersFromDb = userManager.GetUsers();

                if (usersFromDb == null) return NotFound();

                return Ok(userManager.Users);
            }
        }
        
        [HttpPost(Name = "AddUser")]
        public IActionResult AddUser(User user)
        {
            UserManager userManager = new UserManager();
            userManager.AddUser(user);
            
            return CreatedAtAction("GetUser", new { id = user.Id }, user);

        }

        [HttpDelete(Name = "DeleteUser")]
        public IActionResult DeleteUser(int userId)
        {
            UserManager userManager = new UserManager();
            userManager.DeleteUser(userId);

            if (userManager.Users.SingleOrDefault(user => user.Id == userId) == null)
            {
                return Ok(userManager.Users);
            }
            else
            {
                return BadRequest();
            }
           
        }

        //[HttpPatch(Name = "EditUser")]
        //public IActionResult UpdateUser(User user)
        //{
        //    UserManager userManager = new UserManager();
        //    userManager.EditUser(user);
        //    User userfromDb =userManager.Users.SingleOrDefault(u => u.Id == user.Id);
            
        //    if (user==userfromDb)
        //    {
        //        return Ok(userManager.Users);
        //    }
        //    else
        //    {
        //        return BadRequest();
        //    }
        //}
    }
}