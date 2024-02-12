using ECommerceAPI.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Domain.Entities
{
    public class Category : EntityBase
    {
        public Category()
        {

        }

        public Category(int parentId, string name, int priority)
        {
            ParentId = parentId;
            Name = name;
            Priority = priority;
        }

        public required int ParentId { get; set; }
        public required string Name { get; set; }
        public required int Priority { get; set; }
        public ICollection<Detail> Details { get; set; } // Bir kategorinin birden çok alt detayı olabilir. 
        public ICollection<Product> Products { get; set; }
    }
}
