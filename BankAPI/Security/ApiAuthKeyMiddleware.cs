using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAPI.Security
{
    public class ApiAuthKeyMiddleware
    {
        private readonly RequestDelegate _next;
        private const string ApiKeyName = "ApiKey";

        public ApiAuthKeyMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            if (!context.Request.Query.TryGetValue(ApiKeyName, out var potenKey))
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("result=-1 Error Athorization");
                return;
            }

            var configuration = context.RequestServices.GetRequiredService<IConfiguration>();
            var apiKey = configuration.GetValue<string>(ApiKeyName);

            if (!apiKey.Equals(potenKey))
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("result=-1 Unathorized");
                return;
            }
            await _next(context);
        }
    }
}
