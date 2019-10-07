using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanyspieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        private List<Pie> _pies;

        public MockPieRepository()
        {
            if (_pies == null)
            {
                InitializePies();
            }
        }

        private void InitializePies()
        {
            _pies = new List<Pie>
            {
                new Pie {Id=1, Name="Apple Pie", Price = 12.95M, ShortDescription="Pie made of apples", ImageThumbnailUrl="https://i2.wp.com/aspicyperspective.com/wp-content/uploads/2010/09/blueberry-pie-with-sweet-almond-crust-15-256x256.jpg" },
                new Pie {Id=2, Name="Cheese Cake", Price = 11.40M, ShortDescription="Just cheese cake", ImageThumbnailUrl="https://i2.wp.com/aspicyperspective.com/wp-content/uploads/2010/09/blueberry-pie-with-sweet-almond-crust-15-256x256.jpg" },
                new Pie {Id=3, Name="Cherry Pie", Price = 9.50M, ShortDescription="Pie made of cherries", ImageThumbnailUrl="https://i2.wp.com/aspicyperspective.com/wp-content/uploads/2010/09/blueberry-pie-with-sweet-almond-crust-15-256x256.jpg" },
                new Pie {Id=4, Name="Blueberry Cake", Price = 11.75M, ShortDescription="Neki bljak pie", ImageThumbnailUrl="https://i2.wp.com/aspicyperspective.com/wp-content/uploads/2010/09/blueberry-pie-with-sweet-almond-crust-15-256x256.jpg" }
            };
        }
        public IEnumerable<Pie> GetAllPies()
        {
            return _pies;
        }

        public Pie GetPieById(int pieId)
        {
            return _pies.FirstOrDefault(p => p.Id == pieId);
        }
    }
}
