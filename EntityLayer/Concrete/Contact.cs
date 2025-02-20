using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityLayer.Concrete {
    public class Contact {
        public int ContactId { get; set; }  
        public string Name { get; set; } = null!;
        public string Mail { get; set; } = null!;
        public string Message { get; set; } = null!;
        public DateTime Date { get; set; } 

    }
}