namespace HospitalManagement.API.Middlewares
{
    public class TokenExtractorMiddleware
    {
        private readonly RequestDelegate _next;

        public TokenExtractorMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Headers.TryGetValue("Authorization", out var authHeaderValue))
            {
                // Extracting the token from the Authorization header
                string token = authHeaderValue.ToString().Split(' ')[1]; // Assuming Bearer token format

                // Adding the token to request properties for further usage
                context.Items["Token"] = token;
            }

            await _next(context);
        }
    }
}
