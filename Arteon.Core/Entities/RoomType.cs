using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arteon.Core.Entities
{
    public class RoomType : IEntity
    {
        public RoomType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        private RoomType() { }

        public int Id { get; private set; }
        public string Name { get; private set; }    
    }
}
