using System;

namespace Vrnz2.BaseContracts.DTOs.Base
{
    public abstract class BaseDTO
    {
        public abstract class Request 
        {
        
        }

        public abstract class Response<T>
        {
            public virtual bool Success { get; set; }
            public virtual string Message { get; set; }
            public virtual DateTime ReturnDateTime { get; set; } = DateTime.UtcNow;
            public virtual T Content { get; set; }
        }
    }
}
