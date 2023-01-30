using epadoca_challenge.Data;
using epadoca_challenge.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace epadoca_challenge.Repository
{
    public class BakeryRepository : IBakeryRepository
    {

        private readonly BakeryDbContext _contextDb;
        public BakeryRepository(BakeryDbContext bakeryDbContext)
        {
            _contextDb = bakeryDbContext;
        }
        public BakeryModel Add(BakeryModel bakery)
        {
            _contextDb.Bakeries.Add(bakery);
            _contextDb.SaveChanges();
            return bakery;
        }

        public List<BakeryModel> GetAll()
        {
            return _contextDb.Bakeries.ToList();
        }

        public List<BakeryModel> GetById(int bakeryId)
        {
            return _contextDb.Bakeries.Where(x => x.Id == bakeryId).ToList();
        }

        public BakeryModel GetByName(BakeryModel bakery)
        {
           BakeryModel bakeryDb = _contextDb.Bakeries.FirstOrDefault(x => x.Name == bakery.Name);
            if(bakeryDb == null)
            {
                return bakery;
            }
            throw new System.Exception("Padaria já cadastrada");
        }
    }
}
