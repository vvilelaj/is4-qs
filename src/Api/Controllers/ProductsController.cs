using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet("{productId}")]
        public ActionResult<IEnumerable<ProductModel>> GetProducts(string productId)
        {
            return new List<ProductModel> {
                new ProductModel {
                    Id = 1, Name = "Product 001", Description = "Description 001", Price = 100
                },
                new ProductModel {
                    Id = 2, Name = "Product 002", Description = "Description 002", Price = 200
                },
                new ProductModel {
                    Id = 3, Name = "Product 003", Description = "Description 003", Price = 300
                }
            };
        }
    }
}