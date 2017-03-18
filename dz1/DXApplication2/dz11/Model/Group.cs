using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz11.Model
{
    class Group: Base
    {
        public Group()
        {
            Id = Guid.NewGuid();
        }
        public string Name { get; set; }
    }
}
