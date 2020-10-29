using System;
using System.ComponentModel.DataAnnotations;

namespace ServiceCatalog.Entities
{
    public class ServiceItem
    {
        [Required]
        public int ServiceItemId { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
    }
}