using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Eshop.Models;

namespace Eshop.Controllers
{
    public class Basket_ProductWebApiController : ApiController
    {
        private ShoppingStoreDB db = new ShoppingStoreDB();

        // GET: api/Basket_Product
        public IQueryable<Basket_Product> GetBasket_Products()
        {
            return db.Basket_Products;
        }

        // GET: api/Basket_Product/5
        [ResponseType(typeof(Basket_Product))]
        public IHttpActionResult GetBasket_Product(int id)
        {
            Basket_Product basket_Product = db.Basket_Products.Find(id);
            if (basket_Product == null)
            {
                return NotFound();
            }

            return Ok(basket_Product);
        }

        // PUT: api/Basket_Product/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutBasket_Product(int id, Basket_Product basket_Product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != basket_Product.Id_Basket)
            {
                return BadRequest();
            }

            db.Entry(basket_Product).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Basket_ProductExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Basket_Product
        [ResponseType(typeof(Basket_Product))]
        public IHttpActionResult PostBasket_Product(Basket_Product basket_Product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Basket_Products.Add(basket_Product);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (Basket_ProductExists(basket_Product.Id_Basket))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = basket_Product.Id_Basket }, basket_Product);
        }

        // DELETE: api/Basket_Product/5
        [ResponseType(typeof(Basket_Product))]
        public IHttpActionResult DeleteBasket_Product(int id)
        {
            Basket_Product basket_Product = db.Basket_Products.Find(id);
            if (basket_Product == null)
            {
                return NotFound();
            }

            db.Basket_Products.Remove(basket_Product);
            db.SaveChanges();

            return Ok(basket_Product);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Basket_ProductExists(int id)
        {
            return db.Basket_Products.Count(e => e.Id_Basket == id) > 0;
        }
    }
}