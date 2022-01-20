using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DTO.RequestModel.AccountRequestModel
{
    public class GetAccountRequestModel
    {
        public long msisdn { get; set; }
        public long accountCode { get; set; }
    }
}
