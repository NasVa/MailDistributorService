using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mailDistributorService.Models
{
    public class Task
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime startDate { get; set; }
        public DateTime periodDate { get; set; }
        public DateTime lastSend { get; set; }

    }
}
