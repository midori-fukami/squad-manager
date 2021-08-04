using Common;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    /// <summary>
    /// teste
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        /// <summary>
        /// Autentica o usuário
        /// </summary>
        /// <param name="user">Username e Senha do usuário</param>
        /// <returns>OK se estiver OK</returns>
        [HttpPost]
        public IActionResult Login(UserModel user)
        {
            if(user.Password == "123")
                return Ok(new { response = "OK" });
            else
                return Ok(new { response = "ERROR" });
        }

        [HttpPost("create")]
        public IActionResult Create(UserModel user)
        {
            if (user.Password == "123")
                return Ok(new { response = "OK" });
            else
                return Ok(new { response = "ERROR" });
        }
    }
}
