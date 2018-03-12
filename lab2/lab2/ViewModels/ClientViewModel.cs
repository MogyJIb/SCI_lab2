using DbDataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab2.ViewModels
{
    public class ClientViewModel
    {
        public string SelectedYear { get; set; }
        public IEnumerable<Client> Clients { get; set; }
    }
}
