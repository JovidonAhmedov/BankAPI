using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DTO.ResponseModel.AccountResponseModel
{
    public class CreateAccountResponseModel:IResponse
    {
        public int result { get; set; }
        public string message { get; set; }

        public long accountCode { get; set; }
    }
}
