using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DTO.ResponseModel.AccountResponseModel
{
    public class GetAccountResponseModel:IResponse
    {
        public int result { get; set; }
        public string message { get; set; }

        public long msisdn { get; set; }
        public decimal? balance { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public bool? identification { get; set; }
        public long accountCode { get; set; }
    }
}
