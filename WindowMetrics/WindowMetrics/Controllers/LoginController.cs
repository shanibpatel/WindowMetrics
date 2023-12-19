using Microsoft.AspNetCore.Mvc;
using WindowMetrics.Data;
using WindowMetrics.Models;

namespace WindowMetrics.Controllers
{
    public class LoginController : Controller
    {
        private readonly WindowMetricsContext _context;

        public LoginController(WindowMetricsContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            if (ModelState.IsValid)
            {
                var matchingUser = _context.User.FirstOrDefault(u => u.UserName == user.UserName && u.Password == user.Password);

                if (matchingUser != null)
                {
                    // Authentication successful, redirect to UsersController or any other desired action
                    return RedirectToAction("Index", "Users");
                }
                else
                {
                    // Authentication failed, show an error message
                    ModelState.AddModelError(string.Empty, "Invalid username or password");
                    return View("Index", user); // Pass the user model back to the view
                }
            }

            // Model state is not valid, return the view with validation errors
            return View("Index", user);
        }
    }
}
