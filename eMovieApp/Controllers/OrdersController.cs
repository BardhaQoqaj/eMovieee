using eMovieApp.Data.Cart;
using eMovieApp.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace eMovieApp.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IMoviesServices _moviesServices;
        private readonly ShoppingCart _shoppingCart;

        public OrdersController(IMoviesServices moviesServices, ShoppingCart shoppingCart)
        {
            _moviesServices = moviesServices;
            _shoppingCart = shoppingCart;
        }
        public IActionResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var response = new ShoppingCartVM()
            {
                ShoppingCart = _shoppingCart,
            ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(response);
        }
    }
}
