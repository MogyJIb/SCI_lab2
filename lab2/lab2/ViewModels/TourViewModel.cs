using DbDataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab2.ViewModels
{
    public class TourViewModel
    {
        public string SelectedName { get; set; }
        public IEnumerable<Tour> Tours { get; set; }
    }
}
