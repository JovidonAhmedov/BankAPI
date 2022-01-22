using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DTO.ResponseModel
{
    internal class ErrorResponseModel : Response
    {
        public override int Result { get; set; }
        public override string Message { get; set; }
    }
}
