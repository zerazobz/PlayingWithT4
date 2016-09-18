using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceModel.Models
{
    public class PageModel
    {
        public int PageId { get; set; }
        public string PageDescription { get; set; }
        public double PageWidth { get; set; }
        public double PageHeight { get; set; }
    }
}
