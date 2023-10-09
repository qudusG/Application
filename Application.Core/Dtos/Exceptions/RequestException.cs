using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Core.Dtos.Exceptions;

public class RequestException : Exception
{
    public RequestException(int statusCode, string? responseMessage)
        : base()
    {
        StatusCode = statusCode;
        ResponseMessage = responseMessage;
    }
    public string? ResponseMessage { get; set; }
    public int StatusCode { get; set; }
}
