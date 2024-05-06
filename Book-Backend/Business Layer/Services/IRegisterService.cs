using Data_Access_Layer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Services
{
    public interface IRegisterService
    {
        public string Register(UserModel u);
        public UserModel check(Loginmodel u);
    }
}
