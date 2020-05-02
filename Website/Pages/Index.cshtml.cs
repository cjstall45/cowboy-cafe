using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CowboyCafe.Data;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public string SearchTerms { get; set; }

        public string[] Catagories { get; set; }

        public IEnumerable<IOrderItem> Items { get; protected set; }

        
        public void OnGet()
        {
            SearchTerms = Request.Query["SearchTerms"];
            Catagories = Request.Query["Catagory"];
            Items = Menu.Search(Menu.All, SearchTerms);
            Items = Menu.FilterByCatagory(Items, Catagories);
        }
    }
}
