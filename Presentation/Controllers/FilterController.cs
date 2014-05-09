using System.Collections.Generic;
using System.Web.Http;

namespace Presentation.Controllers
{
    public class FilterController : ApiController
    {
        // GET api/filter
        public IEnumerable<object> Get()
        {
            return new[]
            {
                new { id= 0, name= "filter 1", selected= false },
                new { id= 1, name= "filter 2", selected= true },
                new { id= 2, name= "filter 3", selected= false },
                new { id= 3, name= "filter 4", selected= false },
                new { id= 4, name= "filter 5", selected= false },
                new { id= 5, name= "filter 6", selected= false }
            };
        }
    }
}
