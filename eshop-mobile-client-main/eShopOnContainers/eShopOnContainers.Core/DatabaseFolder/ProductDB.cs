﻿using eShopOnContainers.Core.Models.Item;
using Firebase.Database;
using Firebase.Database.Query;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopOnContainers.Core.DatabaseFolder
{
    public class ProductDB
    {

        readonly FirebaseClient firebase = new FirebaseClient("https://customerlist123-42a86-default-rtdb.firebaseio.com/");

        public async Task SaveProductToBasket(Product product)
        {


            await firebase.Child("Sepet").PostAsync(JsonConvert.SerializeObject(product));


        }

        public async Task SaveProductToFavorite(Product product)
        {

            await firebase.Child("Favoriler").PostAsync(JsonConvert.SerializeObject(product));


        }

        public async Task DeleteProductFromBasket(int productId)
        {
            var deleteProduct = (await firebase.Child("Sepet").OnceAsync<Product>()).Where(a => a.Object.Id == productId).FirstOrDefault();
            await firebase.Child("Sepet").Child(deleteProduct.Key).DeleteAsync();

        }

        public async Task DeleteProductFromFavorite(int productId)
        {
            var deleteProduct = (await firebase.Child("Favoriler").OnceAsync<Product>()).Where(a => a.Object.Id == productId).FirstOrDefault();
            await firebase.Child("Favoriler").Child(deleteProduct.Key).DeleteAsync();

        }

        public async Task<List<Product>> GetAllProduct()
        {

            return (await firebase
              .Child("Ürünler")
              .OnceAsync<Product>()).Select(item => new Product
              {
                  Id = item.Object.Id,
                  CategoryId = item.Object.CategoryId,
                  ProductName = item.Object.ProductName,
                  ProductImageUrl = item.Object.ProductImageUrl,
                  UnitPrice = item.Object.UnitPrice,
              }).ToList();

        }

        public async Task<List<Product>> GetAllProductFromBasket()
        {

            return (await firebase
              .Child("Sepet")
              .OnceAsync<Product>()).Select(item => new Product
              {
                  Id = item.Object.Id,
                  CategoryId = item.Object.CategoryId,
                  ProductName = item.Object.ProductName,
                  ProductImageUrl = item.Object.ProductImageUrl,
                  UnitPrice = item.Object.UnitPrice,
              }).ToList();
        }


        public async Task<List<Product>> GetAllProductFromFavorite()
        {

            return (await firebase
              .Child("Favoriler")
              .OnceAsync<Product>()).Select(item => new Product
              {
                  Id = item.Object.Id,
                  CategoryId = item.Object.CategoryId,
                  ProductName = item.Object.ProductName,
                  ProductImageUrl = item.Object.ProductImageUrl,
                  UnitPrice = item.Object.UnitPrice,
              }).ToList();
        }


    }
}
