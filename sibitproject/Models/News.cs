using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sibitproject.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
        public string Footer { get; set; }
        public string Image { get; set; }

        public int? StatusId { get; set; }
        public Status Status { get; set; }

        public int? ContentId { get; set; }
        public Content Content { get; set; }
    }
}
