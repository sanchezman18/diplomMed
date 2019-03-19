using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace diplomMed.Models
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();

        public virtual void AddItem (Equipment equipment, int quantity)
        {
            CartLine line = lineCollection.Where(p => p.Equipment.Id == equipment.Id).FirstOrDefault();

            if (line == null)
            {
                lineCollection.Add(new CartLine
                {
                    Equipment = equipment,
                    Quentity = quantity

                });
            }
            else
            {
                line.Quentity += quantity;
            }
        }

        public virtual void RemoveLine(Equipment equipment) =>
            lineCollection.RemoveAll(i => i.Equipment.Id == equipment.Id);

        public virtual decimal ComputeTotalValue() =>
            lineCollection.Sum(e => e.Equipment.Price * e.Quentity);

        public virtual void Clear() => lineCollection.Clear();

        public virtual IEnumerable<CartLine> Lines => lineCollection;
    }
}
