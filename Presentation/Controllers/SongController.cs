using System.Collections.Generic;
using System.Web.Http;
using Presentation.Models;

namespace Presentation.Controllers
{
    public class SongController : ApiController
    {
        #region songs list
        private static readonly IList<Song> Songs = new[]
        {
            new Song
            {
                Name = "Master of Puppets",
                Percentage = 66,
                Votes = 6503,
                Id = "xnKhsTXoKCI"
            },
            new Song
            {
                Name = "One",
                Percentage = 59,
                Votes = 5859,
                Id = "EzgGTTtR0kc"
            },
            new Song
            {
                Name = "Enter Sandman",
                Percentage = 56,
                Votes = 5555,
                Id = "ZmHhnC9Exss"  
            },
            new Song
            {
                Name = "Fade to Black",
                Percentage = 51,
                Votes = 5007,
                Id = "IfRY3SsozuM"  
            },
            new Song
            {
                Name = "Nothing Else Matters",
                Percentage = 47,
                Votes = 4662,
                Id = "Tj75Arhq5ho"  
            },
            new Song
            {
                Name = "Seek and Destroy",
                Percentage = 46,
                Votes = 4558,
                Id = "J-tvJcTPxHc"  
            },
            new Song
            {
                Name = "Orion",
                Percentage = 46,
                Votes = 4525,
                Id = "-qYqi-EMErU"  
            },
            new Song
            {
                Name = "The Unforgiven",
                Percentage = 46,
                Votes = 4506,
                Id = "Ckom3gf57Yw"  
            },
            new Song
            {
                Name = "Whiskey in the Jar",
                Percentage = 43,
                Votes = 4261,
                Id = "boanuwUMNNQ"  
            },
            new Song
            {
                Name = "For Whom the Bell Tolls",
                Percentage = 43,
                Votes = 4212,
                Id = "bg92QpjRcJk"  
            },
            new Song
            {
                Name = "Battery",
                Percentage = 42,
                Votes = 4151,
                Id = "m99ybtk4QNs"  
            },
            new Song
            {
                Name = "Welcome Home (Sanitarium)",
                Percentage = 42,
                Votes = 4140,
                Id = "V6Dfo4zDduI"  
            },
            new Song
            {
                Name = "Sad But True",
                Percentage = 41,
                Votes = 4071,
                Id = "A8MO7fkZc5o"  
            },
            new Song
            {
                Name = "The Memory Remains",
                Percentage = 35,
                Votes = 3437,
                Id = "Z12LfV6i61k"  
            },
            new Song
            {
                Name = "Creeping Death",
                Percentage = 35,
                Votes = 3418,
                Id = "UO_84C3fpuI"  
            },
            new Song
            {
                Name = "Ride the Lightning",
                Percentage = 33,
                Votes = 3254,
                Id = "uebInqG1pJI"  
            },
            new Song
            {
                Name = "Fuel",
                Percentage = 32,
                Votes = 3192,
                Id = "PvF9PAxe5Ng"  
            },
            new Song
            {
                Name = "The Day That Never Comes",
                Percentage = 32,
                Votes = 3154,
                Id = "Mlahvvymkxc"  
            },
            new Song
            {
                Name = "The Call of Ktulu",
                Percentage = 31,
                Votes = 3062,
                Id = "t1RTgznup5c"  
            },
            new Song
            {
                Name = "Wherever I May Roam",
                Percentage = 28,
                Votes = 2799,
                Id = "cwPg8gJq_Kw"  
            },
            new Song
            {
                Name = "...And Justice for All",
                Percentage = 27,
                Votes = 2665,
                Id = "lfg0_FbIqqw"  
            },
            new Song
            {
                Name = "Until It Sleeps",
                Percentage = 25,
                Votes = 2451,
                Id = "F3WIHtOmkBg"  
            },
            new Song
            {
                Name = "The Unforgiven II",
                Percentage = 25,
                Votes = 2438,
                Id = "G-Bn_kD6QN4"  
            },
            new Song
            {
                Name = "Blackened",
                Percentage = 24,
                Votes = 2398,
                Id = "0dnlPIuRsh8"  
            },
            new Song
            {
                Name = "St. Anger",
                Percentage = 24,
                Votes = 2387,
                Id = "6ajl1ABdD8A"  
            },
            new Song
            {
                Name = "To Live Is To Die",
                Percentage = 23,
                Votes = 2319,
                Id = "k7_hwgD1ugg"  
            },
            new Song
            {
                Name = "Harvester of Sorrow",
                Percentage = 21,
                Votes = 2081,
                Id = "YyQDr4ZBvAA"  
            },
            new Song
            {
                Name = "Mama Said",
                Percentage = 20,
                Votes = 2004,
                Id = "4FKYsUEuvIo"  
            },
            new Song
            {
                Name = "Hit the Lights",
                Percentage = 20,
                Votes = 2003,
                Id = "pB8OvPtf_d0"  
            },
            new Song
            {
                Name = "No Leaf Clover",
                Percentage = 19,
                Votes = 1915,
                Id = "Fd9ohpDDCRU"  
            },
            new Song
            {
                Name = "Die Die My Darling",
                Percentage = 18,
                Votes = 1756,
                Id = "JoolQUDWq-k"  
            },
            new Song
            {
                Name = "The Four Horsemen",
                Percentage = 17,
                Votes = 1670,
                Id = "C4nCy5CITc8"  
            },
            new Song
            {
                Name = "Fixxxer",
                Percentage = 17,
                Votes = 1667,
                Id = "MnpjyNgzJ5Q"  
            },
            new Song
            {
                Name = "Whiplash",
                Percentage = 16,
                Votes = 1621,
                Id = "VmqmBj6DnOc"  
            },
            new Song
            {
                Name = "Turn the Page",
                Percentage = 15,
                Votes = 1503,
                Id = "dOibtqWo6z4"  
            },
            new Song
            {
                Name = "My Friend of Misery",
                Percentage = 15,
                Votes = 1498,
                Id = "ODHhWcEdrvg"  
            },
            new Song
            {
                Name = "Fight Fire With Fire",
                Percentage = 15,
                Votes = 1472,
                Id = "ZnCFWlso-UQ"  
            },
            new Song
            {
                Name = "The Frayed Ends of Sanity",
                Percentage = 14,
                Votes = 1403,
                Id = "8ErhlIykHTU"  
            },
            new Song
            {
                Name = "I Disappear",
                Percentage = 14,
                Votes = 1341,
                Id = "nYSDC3cHoZs"  
            },
            new Song
            {
                Name = "All Nightmare Long",
                Percentage = 13,
                Votes = 1263,
                Id = "EFqjDXy9s5A"  
            },
            new Song
            {
                Name = "The Unforgiven III",
                Percentage = 12,
                Votes = 1213,
                Id = "J3m6et00DfQ"  
            },
            new Song
            {
                Name = "Dyers Eve",
                Percentage = 12,
                Votes = 1183,
                Id = "v6kb5fvv6_A"  
            },
            new Song
            {
                Name = "Motorbreath",
                Percentage = 12,
                Votes = 1180,
                Id = "TWKJmbmOOf4"  
            },
            new Song
            {
                Name = "Damage Inc.",
                Percentage = 11,
                Votes = 1121,
                Id = "NbLMrce7OJI"  
            }
        };
        #endregion


        // GET api/song
        public IEnumerable<Song> Get()
        {
            return Songs;
        }

        // GET api/song/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/song
        public void Post([FromBody]string value)
        {
        }

        // PUT api/song/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/song/5
        public void Delete(int id)
        {
        }
    }
}
