using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using ProductManagement.Entities;
using ProductManagement.Helpers;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace ProductManagement.Repositories.RepositoryImpl
{
    public class UserRepositoryImpl : GeneralRepositoryImpl<User, DataContext>, IUserRepository
    {
        DataContext _context;
        AppSettings _appSettings;
        public UserRepositoryImpl(DataContext context, IOptions<AppSettings> appSettings) : base(context)
        {
            _context = context;
            _appSettings = appSettings.Value;
        }
        public User Login(string username, string password)
        {
            var users = _context.Users.ToList();
            var user = users.Where(x => x.UserName == username && x.Password == password).FirstOrDefault();

            if (user == null)
                return null;

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.UserId.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.Token = tokenHandler.WriteToken(token);

            return user.WithoutPassword();
        }
    }
}