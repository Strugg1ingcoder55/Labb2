using Models;

namespace Logiclayer
{
    public class LogicService
    {
        private InMemoryDatabase InMemoryDatabase = new InMemoryDatabase();

      
        public List<Fordon> GetFordon()
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
        public void Seed()
        {
            InMemoryDatabase.Seed();
        }
    }
}
