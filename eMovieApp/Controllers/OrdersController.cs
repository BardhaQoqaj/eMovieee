﻿using eMovieApp.Data.Cart;
using eMovieApp.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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
        public async Task<IActionResult> AddItemToShoppingCart(int id)
        {
            var item = await _moviesService.GetMovieByIdAsync(id);

            if (item != null)
            {
                _shoppingCart.AddItemToCart(item);
            }
            return RedirectToAction(nameof(ShoppingCart));
        }
        public async Task<IActionResult> RemoveItemFromShoppingCart(int id)
        {
            var item = await _moviesService.GetMovieByIdAsync(id);

            if (item != null)
            {
                _shoppingCart.RemoveItemFromCart(item);
            }
            return RedirectToAction(nameof(ShoppingCart));
        }
    }
}
