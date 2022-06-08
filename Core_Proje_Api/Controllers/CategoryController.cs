﻿using Core_Proje_Api.Dal.ApiContext;
using Core_Proje_Api.Dal.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCategoryList()
        {
            using var c = new Context();
            return Ok(c.Categories.ToList());

        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            using var c = new Context();
            var values = c.Categories.Find(id);
            if (values == null)
            {
                return NotFound();
            }else
            {
                return Ok(values);
            }

    }
        [HttpPost]
        public IActionResult CategoriesAdd(Category p)
        {
            using var c = new Context();
            c.Add(p);
            c.SaveChanges();
            return Created("",p);

        }
        [HttpDelete]
        public IActionResult CategoriesDelete(int id)
        {
            using var c = new Context();
            var values = c.Categories.Find(id);
            if (values == null)
            {
                return NotFound();
            }else
            {
                c.Remove(values);
                c.SaveChanges();
                return NoContent();
            }

        }
        [HttpPut]
        public IActionResult CategoriesUpdate(Category p)
        {
            using var c = new Context();
            //İd Değeri bul
            var values = c.Find<Category> (p.CategoryID);
            if (values == null)
            {
                return NotFound();

            }else
            {
                values.CategoryName = p.CategoryName;
                c.Update(values);
                c.SaveChanges();
                return NoContent();
            }

        }
    }
}
