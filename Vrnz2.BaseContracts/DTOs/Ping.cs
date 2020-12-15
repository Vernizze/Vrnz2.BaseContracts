using System;
using Vrnz2.BaseContracts.DTOs.Base;

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
    {
        public string ServiceDateTime { get; } = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:mm");
        public string ServiceName { get; } = AppDomain.CurrentDomain.FriendlyName;
    }
}
