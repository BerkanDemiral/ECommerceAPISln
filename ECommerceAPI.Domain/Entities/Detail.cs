using ECommerceAPI.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Domain.Entities
{
    public class Detail: EntityBase
    {
        public Detail()
        {
            
        }

        /// <summary>
        /// Constructor içerisinde Category değeri verilmez. Bu değer, bir entity içerisinde; bağımlı ID ile diğer node'a erişmek için vardır. 
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="categoryId"></param>
        public Detail(string title, string description, int categoryId)
        {
            Title = title;
            Description = description;
            CategoryId = categoryId;

        }

        public required string Title { get; set; }
        public required string Description { get; set; }

        // One To Many bir ilişki varsa burada One olan Entity'de Many olan Entity için aşağıdaki tanım yapılır.
        public required int CategoryId { get; set; } 
        public Category category { get; set; }
    }
}
