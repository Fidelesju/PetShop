using System;
using System.Security.Claims;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Options;
using PetShop_backend.PetShop.Bussiness.CoreServices.Interfaces;
using PetShop_backend.PetShop.Data.ApplicationModels;

namespace PetShop_backend.PetShop.Bussiness.CoreServices
{
    public class JwtService : IJwtService
    {
        private readonly AppSettings _appSettings;

        public JwtService(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        public string GetJwtToken(string nameIdentifier, string role)
        {
            JwtSecurityTokenHandler tokenHandler;
            byte[] key;
            SecurityToken securityToken;
            SecurityTokenDescriptor tokenDescriptor;
            string jwtToken;

            tokenHandler = new JwtSecurityTokenHandler();
            key = Encoding.ASCII.GetBytes(_appSettings.Segredo);
            tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, nameIdentifier.ToString()),
                    new Claim(ClaimTypes.Role, role.ToString())
                }),
                // Expires = DateTime.UtcNow.AddHours(2),
                Expires = DateTime.UtcNow.AddYears(100),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature)
            };
            securityToken = tokenHandler.CreateToken(tokenDescriptor);
            jwtToken = tokenHandler.WriteToken(securityToken);
            return jwtToken;
        }
    }
}