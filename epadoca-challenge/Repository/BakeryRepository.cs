using epadoca_challenge.Data;
using epadoca_challenge.Models;
using Microsoft.EntityFrameworkCore;
using System;
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

        public bool Delete(int id)
        {
            BakeryModel bakery = ListById(id);
         _contextDb.Remove(bakery);
         _contextDb.SaveChanges();
            return true;
        
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
            return null;
        }

        public BakeryModel ListById(int id)
        {
          return _contextDb.Bakeries.FirstOrDefault(x=>x.Id == id);
        }

        public BakeryModel PatchBakery(BakeryModel bakery)
        {
            BakeryModel bakeryDb = ListById(bakery.Id);

            bakeryDb.Name = bakery.Name;
            bakeryDb.City = bakery.City;
            bakeryDb.State = bakery.State;
            bakeryDb.Street = bakery.Street;
            bakeryDb.Description = bakery.Description;

            _contextDb.Bakeries.Update(bakeryDb);
            _contextDb.SaveChanges();
            return bakeryDb;  
        }
    }
}
