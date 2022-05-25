using Microsoft.OpenApi.Models;

namespace WebApiSwagger
{
    internal class License : OpenApiLicense
    {
        public new string Name { get; set; }
        public new string Url { get; set; }
    }
}