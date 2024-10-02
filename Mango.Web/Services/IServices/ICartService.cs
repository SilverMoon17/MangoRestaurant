using Mango.Web.Models.CartModels;

namespace Mango.Web.Services.IServices;

public interface ICartService
{
    Task<T> GetCartByUserIdAsync<T>(string userId);
    Task<T> AddToCartAsync<T>(CartDto cartDto);
    Task<T> UpdateCartAsync<T>(CartDto cartDto);
    Task<T> ApplyCoupon<T>(CartDto cartDto);
    Task<T> RemoveCoupon<T>(string userId);
    Task<T> RemoveFromCartAsync<T>(int cartId);
    Task<T> Checkout<T>(CartHeaderDto cartHeaderDto);
}