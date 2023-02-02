using epadoca_challenge.Models;
using epadoca_challenge.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;

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
        
            public IActionResult Edit(BakeryModel bakery)
        {
            BakeryModel bakeryView = _bakeryRepository.ListById(bakery.Id);
            return View(bakeryView);
        }


        public IActionResult ListAllBakeries(int id)
        {
            List<BakeryModel> bakery = _bakeryRepository.GetById(id);
            return PartialView("_BakeriesId", bakery);
        }

        [HttpPost]
        public IActionResult Create(BakeryModel bakery)
        {
            if (ModelState.IsValid) {
                BakeryModel bakeryDb = _bakeryRepository.GetByName(bakery);
                if (bakeryDb != null)
                {
                    _bakeryRepository.Add(bakeryDb);
                    TempData["SuccessMesage"] = "Nova parceria realizada!";
                    return RedirectToAction("Index");
                }
                TempData["ErrorMesage"] = "Padaria já cadastrada";
                return RedirectToAction("Index");

            }

            return View(bakery);
        }

        public IActionResult Delete(int id)
        {
            _bakeryRepository.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult PatchBakery(BakeryModel bakery)
        {
            if (ModelState.IsValid)
            {
                _bakeryRepository.PatchBakery(bakery);
                TempData["SuccessMesage"] = "Informações alteradas com sucesso";
                return RedirectToAction("Index");
            }
            return View("Edit", bakery);
        }
    }

}
