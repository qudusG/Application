using Application.Core.Dtos.Exceptions;
using System.Text;

namespace Application.API.ApplicationServices;

public class ExceptionHandler
{
    private readonly RequestDelegate _next;
    public ExceptionHandler(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext httpContext)
    {
        try
        {
            await _next(httpContext);
        }
        catch (RequestException ex)
        {
            httpContext.Response.ContentType = "application/json";
            string response = $"{{\"Message\":\"{ex.ResponseMessage}\"}}";
            byte[]? responseData = Encoding.UTF8.GetBytes(response);

            httpContext.Response.StatusCode = ex.StatusCode;
            await httpContext.Response.Body.WriteAsync(responseData);
        }

        catch (Exception ex)
        {
            // Application exceptions needs to be logged. Implement logging here.

            httpContext.Response.ContentType = "application/json";
            var response = $"{{\"Message\":\"A system error occurred.\"}}";
            var responseData = Encoding.UTF8.GetBytes(response);

            httpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
            await httpContext.Response.Body.WriteAsync(responseData);
        }
    }
}
