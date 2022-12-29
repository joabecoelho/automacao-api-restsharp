using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio.base2.testes.domain.Dtos.Responses
{
        public class ObterUmBugResponse
        {
            [JsonProperty("issues")]
            public List<Issue> Issues { get; set; }
        }
        public class Category
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }
        }

        public class CustomField
        {
            [JsonProperty("field")]
            public Field Field { get; set; }

            [JsonProperty("value")]
            public string Value { get; set; }
        }

        public class Field
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }
        }

        public class History
        {
            [JsonProperty("created_at")]
            public DateTime CreatedAt { get; set; }

            [JsonProperty("user")]
            public User User { get; set; }

            [JsonProperty("type")]
            public Type Type { get; set; }

            [JsonProperty("message")]
            public string Message { get; set; }
        }

        public class Issue
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("summary")]
            public string Summary { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("project")]
            public Project Project { get; set; }

            [JsonProperty("category")]
            public Category Category { get; set; }

            [JsonProperty("reporter")]
            public Reporter Reporter { get; set; }

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

            [JsonProperty("history")]
            public List<History> History { get; set; }
        }

        public class Priority
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("label")]
            public string Label { get; set; }
        }

        public class Project
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }
        }

        public class Reporter
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("real_name")]
            public string RealName { get; set; }

            [JsonProperty("email")]
            public string Email { get; set; }
        }

        public class Reproducibility
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("label")]
            public string Label { get; set; }
        }

        public class Resolution
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("label")]
            public string Label { get; set; }
        }

        public class Severity
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("label")]
            public string Label { get; set; }
        }

        public class Status
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

        public class Type
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }
        }

        public class User
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("real_name")]
            public string RealName { get; set; }

            [JsonProperty("email")]
            public string Email { get; set; }
        }

        public class ViewState
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("label")]
            public string Label { get; set; }
        }


    }
