using Bconnect.service.IService;
using Bconnect.service.ViewModel;
using Bconnect.data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Bconnect.data.dbcontext;
using Bconnect.data.Entity;

namespace Bconnect.service.Service
{
    public class BusinessCardService : IBusinessCardService
    {
        #region Properties
        private readonly IMapper _mapper;
        private readonly DatabaseContext _db;
        #endregion

        #region Constructor
        public BusinessCardService(IMapper mapper, DatabaseContext db)
        {
            _mapper = mapper;
            _db = db;
        }
        #endregion


        public async Task<ResponseViewModel> SaveBusinessCard(BusinessCardViewModel cardViewModel)
        {
            ResponseViewModel response = new ResponseViewModel();
            try
            {
                _db.BusinessCards.Add(_mapper.Map<BusinessCard>(cardViewModel));
                int result =  _db.SaveChanges();

                if (result > 0)
                {
                    response.IsSuccess = true;
                    response.Status = Convert.ToInt32(EnumManager.Status.Success);
                    response.Message = Message.Success;
                }
                else
                {
                    response.IsSuccess = false;
                    response.Status = Convert.ToInt32(EnumManager.Status.Error);
                    response.Message = Message.Error;
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Status = Convert.ToInt32(EnumManager.Status.Error);
                response.Message = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
            }
            return response;
        }
    }
}
