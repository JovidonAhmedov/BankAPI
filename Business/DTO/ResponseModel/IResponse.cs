using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DTO.ResponseModel
{
    public interface IResponse
    {
        int result { get; set; }
        string message { get; set; }
    }
}
