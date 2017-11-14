﻿using Bootstrap.Data.Entities;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Bootstrap.Data
{
    public class DutchSeeder
    {
        private readonly DutchContext _ctx;
        private readonly IHostingEnvironment hosting;

        public DutchSeeder(DutchContext ctx, IHostingEnvironment hosting)
        {
            _ctx = ctx;
            this.hosting = hosting;
        }

        public void Seed()
        {
            // Makes sure that the database exists.
            _ctx.Database.EnsureCreated();

            if (!_ctx.Products.Any())
            {
                // need to create sample data.
                var filePath = Path.Combine(hosting.ContentRootPath, "Data/art.json");
                var json = File.ReadAllText(filePath);
                var products = JsonConvert.DeserializeObject<IEnumerable<Product>>(json);
                _ctx.Products.AddRange(products);

                var order = new Order()
                {
                    OrderDate = DateTime.Now,
                    OrderNumber = "12345",
                    Items = new List<OrderItem>()
                    {
                        new OrderItem()
                        {
                        Product = products.First(),
                        Quantity = 5,
                        UnitPrice = products.First().Price
                        }
                    }
                };

                _ctx.Orders.Add(order);
                _ctx.SaveChanges();
            }
        }
    }
}
