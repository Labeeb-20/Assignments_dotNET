
using System.Linq.Expressions;

namespace MVCAssignment3.Models
{
    public class HallDataAccess : HallDAO
    {
        private readonly HallDBContext dbctx;
        public HallDataAccess(HallDBContext dbctx)
        {
            this.dbctx = dbctx;
        }
        public override List<Hall> getHall(int price)
        {
                return dbctx.Halls.Where(e => e.CostPerDay <= price).ToList();
        }
    }
}
