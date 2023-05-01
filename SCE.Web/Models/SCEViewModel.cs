using SCE.Web.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCE.Web.Models
{
    public class SCEViewModel
    {
        public List<StarsViewModel> StarsViewModel { get; set; }
        public List<CloseToBookDto> CloseToBook { get; set; }
        public List<SalesCycleExtensionDto> SalesCycleExtension { get; set; }
        public List<SaleSlapseDaysDto> SaleSlapseDays { get; set; }
    }
}