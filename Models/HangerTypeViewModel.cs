using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace TheHangerCompany.Models
{
    public class HangerTypeViewModel
    { 
         public List<Hanger> Hangers { get; set; }
    public SelectList Type { get; set; }
    public string HangerType { get; set; }
    public string SearchString { get; set; }
}
}