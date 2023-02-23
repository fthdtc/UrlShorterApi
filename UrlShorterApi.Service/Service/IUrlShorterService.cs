using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrlShorterApi.Entity.Model;

namespace UrlShorterApi.Service.Service
{
    public interface IUrlShorterService
    {
        Task<ResponseModel> ShortUrlAsync(ShortModel model);
        Task<ResponseModel> RedirectUrlAsync(RedirectModel model);
        Task<ResponseModel> CustomUrlAsync(CustomModel model);
    }
}
