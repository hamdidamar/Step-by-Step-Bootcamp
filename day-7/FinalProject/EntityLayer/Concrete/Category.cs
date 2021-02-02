using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
