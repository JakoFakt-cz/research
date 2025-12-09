using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FactChackerAnalyzatorApp.Models
{
    public class GeminiModel
    { 
        [JsonPropertyName("Fake Score")]
        public int FakeScore { get; set; }

        [JsonPropertyName("Status")]
        public string Status { get; set; }
      
        [JsonPropertyName("Shrnutí")]
        public string Shrnutí { get; set; }

        [JsonPropertyName("Důvody hodnocení")]
        public List<string> Důvody { get; set; }

        [JsonPropertyName("Ověřené zdroje")]
        public List<string> Zdroje { get; set; }
    }
}
