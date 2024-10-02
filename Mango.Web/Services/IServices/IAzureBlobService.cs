namespace Mango.Web.Services.IServices;

public interface IAzureBlobService
{
    Task<T> UploadImage<T>(IFormFile image);
    Task<T> DeleteImage<T>(string imageUrl);
}