﻿using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace WebApiAdministrador.UsuarioJwt
{
    public class ManejoJwt : IManejoJwt
    {
        public IConfiguration configuration;

        public ManejoJwt(IConfiguration _configuration) {

            configuration = _configuration;
        }

        public string GenerarToken(string Email, string Fullname)
        {

            var claims = new[]
            {
                new Claim("email", Email),
                new Claim("fullName", Fullname)
            };

            var llave = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(configuration.GetSection("ConfiguracionJwt:Llave").Get<string>() ?? string.Empty));

            var credentials = new SigningCredentials(llave, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer:null,
                audience:null,
                claims,
                expires: DateTime.Now.AddMinutes(60),
                signingCredentials:credentials
                );

            return new JwtSecurityTokenHandler().WriteToken(token);

        }

    }
}
