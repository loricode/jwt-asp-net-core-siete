using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ModelosAdm.Usuario;
using WebApiAdministrador.UsuarioJwt;

namespace WebApiAdministrador.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {

        private IManejoJwt manejoJwt;

        public LoginController(IManejoJwt manejoJwt) { 
        
            this.manejoJwt = manejoJwt;

        }


        [AllowAnonymous]
        [HttpPost("Autenticar")]
        public string Obtener()
        {
           var s = Usuario.Login().Find(x => x.Email == "angel@gmail.com");

            if (s is not null)
            {

                var token = this.manejoJwt.GenerarToken(s.Email, s.Fullname);

                return "Token: " + token; 

            }

            return " ss:  " + s?.Email;
        }

      


    }

}
