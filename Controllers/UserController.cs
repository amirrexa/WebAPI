// Controllers/UserController.cs
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;

[Route("api/users")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserRepository _userRepository;
    private readonly IJwtService _jwtService;

    public UserController(IUserRepository userRepository, IJwtService jwtService)
    {
        _userRepository = userRepository;
        _jwtService = jwtService;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(UserRegisterRequest request)
    {
        // Implement user registration logic
        // Hash the password and store user data in the database
        // Return success message
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(UserLoginRequest request)
    {
        // Implement user login logic
        // Validate credentials, generate a JWT token
        // Return the token in the response
    }

    [Authorize]
    [HttpGet("profile")]
    public async Task<IActionResult> UserProfile()
    {
        var userId = User.FindFirst(ClaimTypes.Name)?.Value;
        // Access the authenticated user's profile using userId
    }
}