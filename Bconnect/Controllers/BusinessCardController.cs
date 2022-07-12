using Bconnect.data.Common;
using Bconnect.service.IService;
using Bconnect.service.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bconnect.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessCardController : ControllerBase
    {
        #region Properties
        IBusinessCardService businessCardService;
        #endregion

        #region Constructor
        public BusinessCardController(IBusinessCardService businessCardService)
        {
            this.businessCardService = businessCardService;
        }
        #endregion

        #region Api Method
        [HttpPost]
        [Route("SaveBusinessCard")]
        public async Task<ResponseViewModel> SaveBusinessCard(BusinessCardViewModel cardViewModel)
        {
            ResponseViewModel response = new ResponseViewModel();
            try
            {
                response = businessCardService.SaveBusinessCard(cardViewModel).Result;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Status = Convert.ToInt32(EnumManager.Status.Error);
                response.Message = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
            }
            return response;
        }
        #endregion
    }
}
