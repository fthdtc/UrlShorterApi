using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrlShorterApi.Data;
using UrlShorterApi.Entity.Model;

namespace UrlShorterApi.Service.Service
{
    public class UrlShorterService : IUrlShorterService
    {
        private readonly ILogger<UrlShorterService> _logger;
        private readonly IDbContext _dbContext;
        public UrlShorterService(ILogger<UrlShorterService> logger, IDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public async Task<ResponseModel> CustomUrlAsync(CustomModel model)
        {
            var responseModel = new ResponseModel { StatusCode = System.Net.HttpStatusCode.OK };

            try
            {
                if (model == null || String.IsNullOrEmpty(model.ShortenedUrl) || String.IsNullOrEmpty(model.OriginalUrl))
                {
                    responseModel.StatusCode = System.Net.HttpStatusCode.BadRequest;
                    responseModel.Message = "ShortenedUrl or OriginalUrl parameters are required!";
                    return responseModel;
                }



            }
            catch (Exception ex)
            {
                string errMessage = "unexpected error handled while custom url generating!"; 
                responseModel.StatusCode=System.Net.HttpStatusCode.InternalServerError;
                responseModel.Message = errMessage;

                _logger.LogError(new EventId().Id, ex, errMessage);
            }
            return responseModel;
        }

        public async Task<ResponseModel> RedirectUrlAsync(RedirectModel model)
        {
            var responseModel = new ResponseModel { StatusCode = System.Net.HttpStatusCode.OK };

            try
            {
                if (model == null || String.IsNullOrEmpty(model.ShortenedUrl))
                {
                    responseModel.StatusCode = System.Net.HttpStatusCode.BadRequest;
                    responseModel.Message = "ShortenedUrl parameter is required!";
                    return responseModel;
                }



            }
            catch (Exception ex)
            { 
                string errMessage = "unexpected error handled while redirect url!";
                responseModel.StatusCode = System.Net.HttpStatusCode.InternalServerError;
                responseModel.Message = errMessage;

                _logger.LogError(new EventId().Id, ex, errMessage);
            }
            return responseModel;
        }

        public async Task<ResponseModel> ShortUrlAsync(ShortModel model)
        {
            var responseModel = new ResponseModel { StatusCode = System.Net.HttpStatusCode.OK };

            try
            {
                if (model == null || String.IsNullOrEmpty(model.ShortenedUrl))
                {
                    responseModel.StatusCode = System.Net.HttpStatusCode.BadRequest;
                    responseModel.Message = "ShortenedUrl parameter is required!";
                    return responseModel;
                }

                var a = await new DbContext().Get();

            }
            catch (Exception ex)
            {
                string errMessage = "unexpected error handled while short url!"; 
                responseModel.StatusCode = System.Net.HttpStatusCode.InternalServerError;
                responseModel.Message = errMessage;

                _logger.LogError(new EventId().Id, ex, errMessage);
            }
            return responseModel;
        }
    }
}
