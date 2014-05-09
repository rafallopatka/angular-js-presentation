using System.Collections.Generic;
using System.Web.Http;

namespace Presentation.Controllers
{
    public class ColorController : ApiController
    {
        // GET api/color
        public IEnumerable<object> Get()
        {
            return new[]
            {
                new { id = 0, name= "white" },
                new { id= 1, name= "black" },
                new { id= 2, name= "yellow" },
                new { id= 3, name= "red" }
            };
        }
    }
}
