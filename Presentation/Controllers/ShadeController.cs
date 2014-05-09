using System.Collections.Generic;
using System.Web.Http;

namespace Presentation.Controllers
{
    public class ShadeController : ApiController
    {
        // GET api/subfilter
        public IEnumerable<object> Get(int id)
        {
            return new[]
            {
                new { id = 0, name= "shade1" + id  },
                new { id = 1, name= "shade2" + id },
                new { id = 2, name= "shade3" + id },
                new { id = 3, name= "shade4"  + id }
            };
        }
    }
}
