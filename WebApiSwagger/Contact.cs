using Microsoft.OpenApi.Models;

namespace WebApiSwagger
{
    internal class Contact : OpenApiContact
    {
        public new string Name { get; set; }
        public new string Email { get; set; }
        public new string Url { get; set; }
    }
}