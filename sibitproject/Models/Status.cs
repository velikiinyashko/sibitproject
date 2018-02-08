using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sibitproject.Models
{
    public class Status
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<News> News { get; set; }

        public Status()
        {
            News = new List<Models.News>();
        }
    }
}
