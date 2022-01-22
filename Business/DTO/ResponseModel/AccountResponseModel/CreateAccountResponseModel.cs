using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Business.DTO.ResponseModel.AccountResponseModel
{
    public class CreateAccountResponseModel:Response
    {
        public override int Result { get; set; }
        public override string Message { get; set; }

        
        public long accountCode { get; set; }
    }
}
