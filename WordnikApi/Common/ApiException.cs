using System;

namespace WordnikApi.Common
{
    public class ApiException : Exception
    {
        public int Code { get; set; }

        public ApiException()
        {
        }

        public ApiException(int code, string message)
            : base(message)
        {
            this.Code = code;
        }
    }
}
