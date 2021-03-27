using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Campaign:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DiscountAmount { get; set; }
    }
}
