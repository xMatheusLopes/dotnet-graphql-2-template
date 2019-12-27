using System.Collections;
using System.Collections.Generic;

namespace api_graphql2.Models 
{
    public class Club 
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public IEnumerable getClubs() {
            var clubs = new List<Club> {
                new Club { ID = 1, Name = "Corinthians" },
                new Club { ID = 2, Name = "Palmeiras" },
                new Club { ID = 3, Name = "São Paulo" },
                new Club { ID = 4, Name = "Santos" }
            };

            return clubs;
        }
    }
}