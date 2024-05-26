using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zhuravlev_34.Models
{
    public class Client
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        public string Phone{ get; set; }
        public string Address{ get; set; }

    }
}
