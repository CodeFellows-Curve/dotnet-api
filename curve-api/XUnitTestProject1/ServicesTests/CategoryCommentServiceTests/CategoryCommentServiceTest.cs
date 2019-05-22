using curve_api.Models.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Microsoft.EntityFrameworkCore.InMemory;
using curve_api.Data;
using Microsoft.EntityFrameworkCore;

namespace XUnitTestProject1.ServicesTests.CategoryCommentServiceTests
{
    public class CategoryCommentServiceTest
    {
        [Fact]
        public void CanCreateCategoryComment()
        {
            DbContextOptions<CurveDBContext> options = new DbContextOptionsBuilder<CurveDBContext>().UseInMemoryDatabase("CanCreateCategoryComment").Options;

            using (CurveDBContext context = new CurveDBContext(options))
            {
                CategoryCommentService categoryCommentService = new CategoryCommentService()
                {
                    Id = 12,
                    UserId = 5,
                    CategoryId = 6,
                    Subject = $"TestSubject - Category {6}",
                    Content = "TestContent - Review 1",
                };
            }
        }
    }
}


//[Fact]
//public static async Task TestFindBasketByUserLazy()
//{
//    DbContextOptions<ProductDBContext> options = new DbContextOptionsBuilder<ProductDBContext>().UseInMemoryDatabase("TestFindBasketByUserLazy").Options;

//    using (ProductDBContext context = new ProductDBContext(options))
//    {

//        Product product = new Product()
//        {
//            ID = 0,
//            Sku = "Test/Sku/Test",
//            Name = "TestProduct",
//            Description = "TestProduct",
//            Price = 1.00m,
//            Image = "TestImage"
//        };
//        context.Add(product);

//        Basket basket = new Basket
//        {
//            ID = 0,
//            UserName = "TestBasket",
//            Subtotal = 2.00m,
//            BasketItems = new List<BasketItem>()
//        };
//        context.Add(basket);

//        BasketItem basketItem = new BasketItem
//        {
//            BasketID = basket.ID,
//            ProductID = product.ID,
//            Quantity = 2,
//            Product = product,
//            Basket = basket,

//        };
//        context.Add(basketItem);

//        context.SaveChanges();

//        BasketService bs = new BasketService(context);

//        Basket test = await bs.FindBasketByUserLazy("TestBasket");

//        Assert.Equal(2, test.Subtotal);
//    }
//}

