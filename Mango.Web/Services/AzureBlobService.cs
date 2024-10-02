using Mango.Web.Models;

namespace Mango.Web.Services.IServices;

public class AzureBlobService : BaseService, IAzureBlobService
{
    private readonly IHttpClientFactory _clientFactory;

    public AzureBlobService(IHttpClientFactory clientFactory) : base(clientFactory)
    {
        _clientFactory = clientFactory;
    }

    public async Task<T> UploadImage<T>(IFormFile image)
    {
        return await this.SendAsync<T>(new ApiRequest()
        {
            ApiType = SD.ApiType.POST,
            Data = image,
            Url = SD.AzureBlobAPIBase + "/api/AzureBlob/Upload"
        });
    }
    
    public async Task<T> DeleteImage<T>(string imageUrl)
    {
        return await this.SendAsync<T>(new ApiRequest()
        {
            ApiType = SD.ApiType.DELETE,
            Data = imageUrl,
            Url = SD.AzureBlobAPIBase + "/api/AzureBlob/Delete"
        });
    }
}