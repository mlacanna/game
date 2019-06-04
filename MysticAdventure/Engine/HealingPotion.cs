using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class HealingPotion : Item //healing pot is from the base class of item
    {
        //also includes id and name from the item class
        public int AmountToHeal { get; set; }

        public HealingPotion(int id, string name, string namePlural, int amountToHeal) : base(id, name, namePlural) //base is what it is grabbing from the base class
        {
            AmountToHeal = AmountToHeal;
        }
    }
}
