using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sibitproject.Models
{
    public class Content
    {
        public int Id { get; set; }
        public string ContType { get; set; }

        public List<News> News { get; set; }

        public Content()
        {
            News = new List<Models.News>();
        }
    }
}
