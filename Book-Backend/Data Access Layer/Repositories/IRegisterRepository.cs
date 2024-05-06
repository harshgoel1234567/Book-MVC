using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer.Entity;
namespace Data_Access_Layer.Repositories
{
    public interface IRegisterRepository
    {
        public string Register(UserModel u);
        public UserModel check(Loginmodel u);
       
    }
}
