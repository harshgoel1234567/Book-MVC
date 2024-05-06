using Data_Access_Layer.Data;
using Data_Access_Layer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repositories
{
    public class RegisterRepository : IRegisterRepository
    {
        private readonly FullStackDbContext _dbContext;
        public RegisterRepository(FullStackDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public string Register(UserModel u)
        {
            try
            {
                _dbContext.User.AddAsync(u);
                _dbContext.SaveChanges();
                return "Added";

            }
            catch
            {
                return "Not-Aadded";
            }

        }
        public UserModel check(Loginmodel u)
        {
            try
            {
                var s=_dbContext.User.FirstOrDefault(user => user.UserName == u.Username && user.Password == u.Password);
                if (s != null)
                {
                    return s;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
