using Data_Access_Layer.Entity;
using Data_Access_Layer.Repositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Services
{
    public class RegisterService : IRegisterService
    {
        public readonly IRegisterRepository _repository;

        public RegisterService(IRegisterRepository repository)
        {
            _repository = repository;
        }

        public string Register(UserModel u)
        {
        return _repository.Register(u);
        }
        public UserModel check(Loginmodel u)
        {
            return _repository.check(u);
        }
    }
}
