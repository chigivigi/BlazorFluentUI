using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorFluentUI.Demo.Shared.Models
{
    public class CustomGrid
    {
        public string id { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string type { get; set; }
        public int amount { get; set; }
        public Guid secondid { get; set; }
        public bool visible { get; set; }
        public string status { get; set; }
        public IDropdownOption secondstatus { get; set; }
    }
}
