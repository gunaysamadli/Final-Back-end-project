﻿using Mejuri_Back_end.Models;
using Mejuri_Back_end.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mejuri_Back_end.Services
{
    public class LayoutService
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly UserManager<AppUser> _userManager;

        public LayoutService(AppDbContext context, IHttpContextAccessor contextAccessor, UserManager<AppUser> userManager)
        {
            _context = context;
            _contextAccessor = contextAccessor;
            _userManager = userManager;
        }

        public Setting GetSetting()
        {
            return _context.Settings.FirstOrDefault();
        }

        public List<BasketItemViewModel> GetBasketItems()
        {
            List<BasketItemViewModel> items = new List<BasketItemViewModel>();

            AppUser member = null;
            if (_contextAccessor.HttpContext.User.Identity.IsAuthenticated)
            {
                member = _userManager.Users.FirstOrDefault(x => x.UserName == _contextAccessor.HttpContext.User.Identity.Name && !x.IsAdmin);
            }


            if (member == null)
            {
                var itemsStr = _contextAccessor.HttpContext.Request.Cookies["Products"];

                if (itemsStr != null)
                {
                    items = JsonConvert.DeserializeObject<List<BasketItemViewModel>>(itemsStr);

                    foreach (var item in items)
                    {
                        ProductColor product = _context.ProductColors.Include(x => x.Color).
                            Include(x => x.Product).Include(c => c.ProductColorImages).FirstOrDefault(x => x.Id == item.ProductColorId);
                        if (product != null)
                        {
                            Company company = _context.Companies.FirstOrDefault(x => x.ProductId == product.ProductId);
                            item.Name = product.Product.Name;
                            item.ColorName = product.Color.Name;
                            item.Price = (company != null) ? ((100 - company.Percent) * product.Product.SalePrice) / 100 : product.Product.SalePrice;
                            item.Image = product.ProductColorImages.FirstOrDefault(x => x.PosterStatus == true)?.Image;
                        }
                    }
                }
            }
            else
            {

                List<BasketItem> basketItems = _context.BasketItems
                    .Include(x => x.ProductColor).ThenInclude(x => x.ProductColorImages)
                    .Include(x => x.ProductColor).ThenInclude(x => x.Product).ThenInclude(x => x.Companies)
                    .Include(x => x.ProductColor).ThenInclude(x => x.Color)
                    .Where(x => x.AppUserId == member.Id).ToList();

                items = basketItems.Select(x => new BasketItemViewModel
                {
                    ProductColorId = x.ProductColorId,
                    Count = x.Count,
                    Image = x.ProductColor.ProductColorImages.FirstOrDefault(bi => bi.PosterStatus == true)?.Image,
                    Name = x.ProductColor.Product.Name,
                    ColorName = x.ProductColor.Color.Name,
                    Price = _context.Companies.Any(c => c.ProductId == x.ProductColor.ProductId) ?
                    ((100 - (_context.Companies.FirstOrDefault(c => c.ProductId == x.ProductColor.ProductId).Percent)) * x.ProductColor.Product.SalePrice) / 100 :
                    x.ProductColor.Product.SalePrice                   
                }).ToList();
            }

            return items;
        }

        public List<FavoryItemViewModel> GetFavItems()
        {

            AppUser member = null;
            if (_contextAccessor.HttpContext.User.Identity.IsAuthenticated)
            {
                member = _userManager.Users.FirstOrDefault(x => x.UserName == _contextAccessor.HttpContext.User.Identity.Name && !x.IsAdmin);
            }
            List<FavoryItemViewModel> items = new List<FavoryItemViewModel>();

            if (member == null)
            {
                var itemsStr = _contextAccessor.HttpContext.Request.Cookies["Favory"];

                if (itemsStr != null)
                {
                    items = JsonConvert.DeserializeObject<List<FavoryItemViewModel>>(itemsStr);

                    foreach (var item in items)
                    {
                        ProductColor product = _context.ProductColors.Include(x => x.Product).Include(c => c.Color)
                            .Include(x => x.Product).Include(c => c.ProductColorImages).FirstOrDefault(x => x.Id == item.ProductColorId);
                        if (product != null)
                        {
                            Company company = _context.Companies.FirstOrDefault(x => x.ProductId == product.ProductId);
                            item.Name = product.Product.Name;
                            item.ColorName = product.Color.Name;
                            item.Price = (company != null) ? ((100 - company.Percent) * product.Product.SalePrice) / 100 : product.Product.SalePrice;
                            item.Image = product.ProductColorImages.FirstOrDefault(x => x.PosterStatus == true)?.Image;

                        }
                    }
                }
            }
            else
            {
                List<FavoryItem> basketItems = _context.FavoryItems
                    .Include(x => x.ProductColor).ThenInclude(x => x.ProductColorImages)
                    .Include(x => x.ProductColor).ThenInclude(x => x.Product)
                    .Include(x => x.ProductColor).ThenInclude(x => x.Color)
                    .Where(x => x.AppUserId == member.Id).ToList();

                items = basketItems.Select(x => new FavoryItemViewModel
                {
                    ProductColorId = x.ProductColorId,
                    Image = x.ProductColor.ProductColorImages.FirstOrDefault(bi => bi.PosterStatus == true)?.Image,
                    Name = x.ProductColor.Product.Name,
                    ColorName=x.ProductColor.Color.Name,
                    Price = _context.Companies.Any(c => c.ProductId == x.ProductColor.ProductId) ?
                    ((100 - (_context.Companies.FirstOrDefault(c => c.ProductId == x.ProductColor.ProductId).Percent)) * x.ProductColor.Product.SalePrice) / 100 :
                    x.ProductColor.Product.SalePrice
                }).ToList();
            }

            return items;
        }
    }

}
