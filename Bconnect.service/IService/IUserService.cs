using Bconnect.service.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bconnect.service.IService
{
    public interface IUserService
    {
        Task<ResponseViewModel> Login(LoginViewModel loginModel);
        Task<ResponseViewModel> RegisterAdmin(RegisterViewModel model);
        Task<ResponseViewModel> Register(RegisterViewModel model);
    }
}
