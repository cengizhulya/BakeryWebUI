using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Detail
    {
        [Key]
        public int DetailsId { get; set; }
        public string Theme { get; set; }
        public int ServingSize { get; set; }
        public string Shape { get; set; }
        public string MessageOnCake { get; set; }
        public string CakeFlavor { get; set; }
        public string Status { get; set; }
        public int TiersOfCake { get; set; }
    }
}
