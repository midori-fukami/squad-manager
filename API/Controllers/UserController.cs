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
        /// <param name="username">Username do usuário</param>
        /// <param name="password">Senha do usuário</param>
        /// <returns>OK</returns>
        [HttpGet]
        public IActionResult Login(string username, string password)
        {
            return Ok(new { response = "Está logado" });
        }
    }
}
