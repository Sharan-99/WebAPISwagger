using Microsoft.OpenApi.Models;

namespace WebApiSwagger
{
    internal class Info : OpenApiInfo
    {
        public new string Title { get; set; }
        public new string Version { get; set; }
        public new string Description { get; set; }
        public new string TermsOfService { get; set; }
        public new Contact Contact { get; set; }
        public new License License { get; set; }
    }
}