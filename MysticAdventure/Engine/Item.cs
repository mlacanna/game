using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Item //base class for every item
    {
        public int ID { get; set; } //sets the id, in all the other classes
        public string Name { get; set; } //giving the items a name
        public string NamePlural { get; set; }

        public Item(int id, string name, string namePlural)
        {
            ID = id;
            Name = name;
            NamePlural = namePlural;
        }
    }
}
