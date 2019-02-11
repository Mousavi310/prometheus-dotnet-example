using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Prometheus;

namespace prometheus_dotnet_example
{
    public class HttpMetricsMiddleware
    {
        private readonly RequestDelegate _next;
        private static readonly Counter RequestCountByMethod = Metrics
	            .CreateCounter("requests_total", "Number of requests received, by HTTP method.",
                new CounterConfiguration
                {
                    LabelNames = new[] { "method", "code", "path" }
                });

        public HttpMetricsMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            await _next(context);
            RequestCountByMethod.WithLabels(context.Request.Method, 
            context.Response.StatusCode + "", 
            context.Request.Path).Inc(1);
        }   
    }
}