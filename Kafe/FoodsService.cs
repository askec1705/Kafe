using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafe
{
    public class FoodsService
    {
        private ProjectContext _context;
        public FoodsService()
        {
            _context = new ProjectContext();
        }
        public bool Add(Food food)
        {
            _context.Foods.Add(food).State = System.Data.Entity.EntityState.Added;
            return _context.SaveChanges() > 0;
        }
        public bool Delete(Food food)
        {
            _context.Foods.Attach(food);
            _context.Foods.Remove(food);
            return _context.SaveChanges() > 0;
        }
        public bool Update(Food food)
        {
            _context.Entry(food).State = System.Data.Entity.EntityState.Modified;// changetracker state'i modified ise güncelleme yapar.
            return _context.SaveChanges() > 0;
        }
    }
}
