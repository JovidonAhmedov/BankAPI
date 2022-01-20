using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DTO.ReponseModel
{
    public interface IResponse
    {
        int result { get; set; }
        string message { get; set; }
    }
}
