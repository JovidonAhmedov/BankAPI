using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DTO.ResponseModel
{
    public abstract class Response
    {
        public abstract int Result { get; set; }
        public abstract string Message { get; set; }
    }
}
