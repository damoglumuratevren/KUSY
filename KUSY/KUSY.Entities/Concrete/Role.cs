using KUSY.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSY.Entities.Concrete
{
    public class Role : EntityBase, IEntity
    {
        public string Name { get; set; }
        public string? Description { get; set; }

        //public int User { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
