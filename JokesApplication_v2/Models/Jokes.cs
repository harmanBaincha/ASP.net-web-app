using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokesApplication_v2.Models
{
    public class Jokes
    {
        public int Id { get; set; }
        public string JokeQues { get; set; }
        public string JokeAns { get; set; }

        public Jokes()
        {

        }
    }
}
