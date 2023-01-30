using epadoca_challenge.Models;
using epadoca_challenge.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace epadoca_challenge.Controllers
{
    public class BakeryController : Controller
    {
        private readonly IBakeryRepository _bakeryRepository;

        public BakeryController(IBakeryRepository bakeryRepository)
        {
            _bakeryRepository = bakeryRepository;
        }
        public IActionResult Index()
        {
            List<BakeryModel> bakery = _bakeryRepository.GetAll();
            return View(bakery);
        }


        public IActionResult Create()
        {
            return View();
        }


        public IActionResult ListAllBakeries(int id)
        {
            List<BakeryModel> bakery = _bakeryRepository.GetById(id);
            return PartialView("_BakeriesId", bakery);
        }

        [HttpPost]
        public IActionResult Add(BakeryModel bakery)
        {

            BakeryModel bakeryDb = _bakeryRepository.GetByName(bakery);
            if (bakeryDb != null)
            {
                _bakeryRepository.Add(bakeryDb);
                return RedirectToAction("Index");
            }
            throw new System.Exception("a já cadastrada");

        }
    }

}
