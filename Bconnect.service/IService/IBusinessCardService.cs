using Bconnect.service.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bconnect.service.IService
{
    public interface IBusinessCardService
    {
        Task<ResponseViewModel> SaveBusinessCard(BusinessCardViewModel cardViewModel);
    }
}
