using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb2;

namespace Logiclayer
{
    public class Logiclayer
    {
        private InMemoryDatabase InMemoryDatabase = new InMemoryDatabase();

      
        public ICollection<Fordon> GetFordon()
        {
            return InMemoryDatabase.fordons;
        }

        public void Addfordon(Fordon fordon)
        {
            InMemoryDatabase.fordons.Add(fordon);
        }
        public void Removefordon(Fordon fordon)
        {
            InMemoryDatabase.fordons.Remove(fordon);
        }
    }
}
