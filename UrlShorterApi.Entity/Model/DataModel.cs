using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrlShorterApi.Entity.Model
{
    public class DataModel
    {
        public string OriginalUrl { get; set; }
        public string ShortedUrl { get; set; }
    }
}
