using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Security.Principal;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        
        public string CategoryName { get; set; }

    }
}
