using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DTO.ResponseModel.AccountResponseModel
{
    public class GetAccountResponseModel :Response
    {
        public override int Result { get; set; }
        public override string Message { get; set; }

        public long msisdn { get; set; }
        public decimal? balance { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public bool? identification { get; set; }
        public long accountCode { get; set; }
    }
}
