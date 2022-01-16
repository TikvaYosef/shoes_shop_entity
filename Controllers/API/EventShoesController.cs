using shoes_shop_entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace shoes_shop_entity.Controllers.API
{
    public class EventShoesController : ApiController
    {
        private ShoesDataContext datacontext = new ShoesDataContext();
        // GET: api/EventShoes
        public IHttpActionResult Get()
        {
            List<Eventshoes> shoes = datacontext.EventShoes.ToList();
            return Ok(new { shoes });
        }
        // GET: api/EventShoes/5
        public async Task<IHttpActionResult> Get(int id)
        {
            try
            {
                Eventshoes shoe = await datacontext.EventShoes.FindAsync(id);
                return Ok(shoe);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        // POST: api/EventShoes
        public async Task<IHttpActionResult> Post([FromBody] Eventshoes obj)
        {
            try
            {
                datacontext.EventShoes.Add(obj);
                await datacontext.SaveChangesAsync();
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/EventShoes/5
        public async Task<IHttpActionResult> Put(int id, [FromBody] Eventshoes obj)
        {
            try
            {
                Eventshoes shoe = await datacontext.EventShoes.FindAsync(id);
                shoe.company = obj.company;
                shoe.instock = obj.instock;
                shoe.size = obj.size;
                shoe.heels = obj.heels;
                shoe.price = obj.price;
                await datacontext.SaveChangesAsync();
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        // DELETE: api/EventShoes/5
        public async Task<IHttpActionResult> Delete(int id)
        {
            try
            {
                Eventshoes shoe = await datacontext.EventShoes.FindAsync(id);
                datacontext.EventShoes.Remove(shoe);
                await datacontext.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
