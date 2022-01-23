using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DTO.ResponseModel
{
    public class ErrorResponseModel : Response
    {
        public override int Result { get; set; }
        public override string Message { get; set; }
    }
}
