using Mango.Web.Models;
using Mango.Web.Models.CartModels;

namespace Mango.Web.Services.IServices;

public class CartService : BaseService, ICartService
{
    private readonly IHttpClientFactory _clientFactory;

    public CartService(IHttpClientFactory clientFactory) : base(clientFactory)
    {
        _clientFactory = clientFactory;
    }
    
    public async Task<T> GetCartByUserIdAsync<T>(string userId)
    {
        return await this.SendAsync<T>(new ApiRequest()
        {
            ApiType = SD.ApiType.GET,
            Url = SD.ShoppingCartAPIBase + "/api/cart/GetCart/" + userId,
            
        });
    }

    public async Task<T> AddToCartAsync<T>(CartDto cartDto)
    {
        return await this.SendAsync<T>(new ApiRequest()
        {
            ApiType = SD.ApiType.POST,
            Data = cartDto,
            Url = SD.ShoppingCartAPIBase + "/api/cart/AddCart",
            
        });
    }

    public async Task<T> UpdateCartAsync<T>(CartDto cartDto)
    {
        return await this.SendAsync<T>(new ApiRequest()
        {
            ApiType = SD.ApiType.PUT,
            Data = cartDto,
            Url = SD.ShoppingCartAPIBase + "/api/cart/UpdateCart",
            
        });
    }

    public async Task<T> ApplyCoupon<T>(CartDto cartDto)
    {
        return await this.SendAsync<T>(new ApiRequest()
        {
            ApiType = SD.ApiType.POST,
            Data = cartDto,
            Url = SD.ShoppingCartAPIBase + "/api/cart/ApplyCoupon",
            
        });
    }

    public async Task<T> RemoveCoupon<T>(string userId)
    {
        return await this.SendAsync<T>(new ApiRequest()
        {
            ApiType = SD.ApiType.POST,
            Data = userId,
            Url = SD.ShoppingCartAPIBase + "/api/cart/RemoveCoupon",
            
        });
    }

    public async Task<T> RemoveFromCartAsync<T>(int cartId)
    {
        return await this.SendAsync<T>(new ApiRequest()
        {
            ApiType = SD.ApiType.DELETE,
            Data = cartId,
            Url = SD.ShoppingCartAPIBase + "/api/cart/RemoveCart",
            
        });
    }

    public async Task<T> Checkout<T>(CartHeaderDto cartHeaderDto)
    {
        return await this.SendAsync<T>(new ApiRequest()
        {
            ApiType = SD.ApiType.POST,
            Data = cartHeaderDto,
            Url = SD.ShoppingCartAPIBase + "/api/cart/Checkout",
            
        });
    }
}