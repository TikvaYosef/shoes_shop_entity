using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace shoes_shop_entity.Models
{
    public class Eventshoes
    {

        public int id { get; set; }
        public string company { get; set; }
        public string gender { get; set; }
        public bool heels { get; set; }
        public bool instock { get; set; }
        public int size { get; set; }
        public int price { get; set; }
    }
}