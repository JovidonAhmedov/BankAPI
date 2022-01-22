using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DTO.RequestModel.AccountRequestModel
{
    public class CreateAccountRequestModel
    {
        public long msisdn { get; set; }
        public string name { get; set; }
        public string surname { get; set; }

    }
}
