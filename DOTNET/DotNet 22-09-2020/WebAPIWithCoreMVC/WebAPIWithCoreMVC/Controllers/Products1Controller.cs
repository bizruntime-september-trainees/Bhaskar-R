using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPIWithCoreMVC.Models;

namespace WebAPIWithCoreMVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Products1Controller : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Products> Get()
        {
            using (var entities = new MyDBAPIContext())
            {
                return entities.Products.ToList();
            }

        }
    }
}
