using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.ViewModel.Common
{
    public class PagedResult<T> : PageResultBase  where T : class
    {
        public List<T> Items { get; set; }
    }
}
