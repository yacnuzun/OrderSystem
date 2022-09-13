using Core.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Order : IEntity
    {
        public int Id { get; set; }
        public int TotalAmount { get; set; }
        public int CompanyId { get; set; }
        public DateTime Date { get; set; }
    }
    
}
