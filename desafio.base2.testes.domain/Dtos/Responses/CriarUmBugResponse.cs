using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio.base2.testes.domain.Dtos.Responses
{
        public class CriarUmBugResponse
        {
            [JsonProperty("issue")]
            public Issue Issue { get; set; }
        }
        public class Categoryy
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }
        }

        public class CustomFieldd
        {
            [JsonProperty("field")]
            public Field Field { get; set; }

            [JsonProperty("value")]
            public string Value { get; set; }
        }

        public class Fieldd
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("label")]
            public string Label { get; set; }
        }

        public class Handlerr
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }
        }

        public class Historyy
        {
            [JsonProperty("created_at")]
            public DateTime CreatedAt { get; set; }

            [JsonProperty("user")]
            public User User { get; set; }

            [JsonProperty("type")]
            public Type Type { get; set; }

            [JsonProperty("message")]
            public string Message { get; set; }

            [JsonProperty("field")]
            public Field Field { get; set; }

            [JsonProperty("old_value")]
            public OldValuee OldValue { get; set; }

            [JsonProperty("new_value")]
            public NewValuee NewValue { get; set; }

            [JsonProperty("change")]
            public string Change { get; set; }

            [JsonProperty("tag")]
            public Tagg Tag { get; set; }
        }

        public class Issuee
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("summary")]
            public string Summary { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("additional_information")]
            public string AdditionalInformation { get; set; }

            [JsonProperty("project")]
            public Project Project { get; set; }

            [JsonProperty("category")]
            public Category Category { get; set; }

            [JsonProperty("reporter")]
            public Reporter Reporter { get; set; }

            [JsonProperty("handler")]
            public Handlerr Handler { get; set; }

            [JsonProperty("status")]
            public Status Status { get; set; }

            [JsonProperty("resolution")]
            public Resolution Resolution { get; set; }

            [JsonProperty("view_state")]
            public ViewState ViewState { get; set; }

            [JsonProperty("priority")]
            public Priority Priority { get; set; }

            [JsonProperty("severity")]
            public Severity Severity { get; set; }

            [JsonProperty("reproducibility")]
            public Reproducibility Reproducibility { get; set; }

            [JsonProperty("sticky")]
            public bool Sticky { get; set; }

            [JsonProperty("created_at")]
            public DateTime CreatedAt { get; set; }

            [JsonProperty("updated_at")]
            public DateTime UpdatedAt { get; set; }

            [JsonProperty("custom_fields")]
            public List<CustomField> CustomFields { get; set; }

            [JsonProperty("tags")]
            public List<Tagg> Tags { get; set; }

            [JsonProperty("history")]
            public List<History> History { get; set; }
        }

        public class NewValuee
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("label")]
            public string Label { get; set; }

            [JsonProperty("color")]
            public string Color { get; set; }
        }

        public class OldValuee
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("label")]
            public string Label { get; set; }

            [JsonProperty("color")]
            public string Color { get; set; }
        }

        public class Priorityy
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("label")]
            public string Label { get; set; }
        }

        public class Projectt
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }
        }

        public class Reporterr
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }
        }

        public class Reproducibilityy
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("label")]
            public string Label { get; set; }
        }

        public class Resolutionn
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("label")]
            public string Label { get; set; }
        }

        public class Severityy
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("label")]
            public string Label { get; set; }
        }

        public class Statuss
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("label")]
            public string Label { get; set; }

            [JsonProperty("color")]
            public string Color { get; set; }
        }

        public class Tagg
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }
        }

        public class Tag2
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }
        }

        public class Typee
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }
        }

        public class Userr
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("email")]
            public string Email { get; set; }
        }

        public class ViewStatee
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("label")]
            public string Label { get; set; }
        }
    }
