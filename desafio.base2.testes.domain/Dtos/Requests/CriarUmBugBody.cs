using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio.base2.testes.domain.Dtos.Requests
{
        public class CriarUmBugBody
        {
        
            [JsonProperty("summary")]
            public string Summary { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("category")]
            public Category Category { get; set; }

            [JsonProperty("project")]
            public Project Project { get; set; }
        }
        public class Category
        {
            [JsonProperty("name")]
            public string Name { get; set; }
        }

        public class Project
        {
            [JsonProperty("name")]
            public string Name { get; set; }
        }

    }
