using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ServiceCatalog.Entities
{
    public class Category
    {
        [Required]
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public List<ServiceItem> ServiceItems { get; set; }
    }
}