using Vrnz2.BaseContracts.DTOs.Base;
using System;
using System.Net;

namespace Vrnz2.BaseContracts.DTOs
{
    public class Ping
        : BaseDTO
    {
        public class Request 
            : BaseDTO.Request
        {
        
        }

        public class Response 
            : Response<PingResponse>
        {
            public override bool Success => true;
            public override string Message => "Ok";
            public override PingResponse Content => new PingResponse();
        }
    }

    public class PingResponse
        : BaseDTO.Response<Ping.Request>
    {
        public string ServiceDateTime { get; } = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:mm");
        public string ServiceName { get; } = AppDomain.CurrentDomain.FriendlyName;


        public override bool Success => true;
        public override int? StatusCode => (int)HttpStatusCode.OK;
        public override string Message => "Success!";
    }
}
