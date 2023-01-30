using epadoca_challenge.Models;
using System.Collections.Generic;

namespace epadoca_challenge.Repository
{
    public interface IBakeryRepository
    {
        BakeryModel Add(BakeryModel bakery);

        BakeryModel GetByName(BakeryModel bakery);

        List<BakeryModel> GetAll();

        List<BakeryModel> GetById(int bakeryId);

        BakeryModel ListById(int id);

        BakeryModel PatchBakery(BakeryModel bakery);

        bool Delete(int id);
    }
}
