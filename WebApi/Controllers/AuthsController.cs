using Business.Abstract;
using Entity.Dto_s;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthsController : ControllerBase
    {
      private  IAuthService _authService;
        public AuthsController(IAuthService authService)
        {
            _authService = authService;
        }
        [HttpPost("Register")]
        public IActionResult Register(UserForRegisterDto userForRegisterDto)
        {
            var userExist = _authService.UserExists(userForRegisterDto.Email);

            if (!userExist.Success)
            {
                return BadRequest(userExist.Message);
            }
            var registerUser = _authService.Register(userForRegisterDto,userForRegisterDto.Password);
            var result = _authService.CreateAccessToken(registerUser.Data);
            if (!registerUser.Success)
            {
                return BadRequest(registerUser.Message);
            }
            return Ok(result.Data);

        }
        [HttpPost("Login")]
        public IActionResult Login(UserForLoginDto userForLoginDto)
        {
            var userToLogin = _authService.Login(userForLoginDto);
            var result = _authService.CreateAccessToken(userToLogin.Data);
            if (!userToLogin.Success)
            {
                return BadRequest(userToLogin.Message);
            }
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);

        }
    }
}
