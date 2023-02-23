using System.Net;

namespace UrlShorterApi.Entity.Model
{
    public class ResponseModel
    {
        public string OriginalUrl { get; set; }
        public string Message { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}
