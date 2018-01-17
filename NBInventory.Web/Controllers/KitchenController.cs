using NBInventory.DTO;
using NBInventory.Services.IServices;
using NBInventory.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NBInventory.Web.Controllers
{
    public class KitchenController : Controller 
    {
        private readonly IKitchenServices _db;
        public KitchenController()
        {
            _db = new KitchenServices();
        }
        // GET: Kitchen
        public ActionResult Index()
        {
            return View(_db.GetKitchens());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create (KitchenDTO kitchenDTO)
        {
            _db.Create(kitchenDTO);
            return RedirectToAction("Index");
        }
        
        [HttpGet]
        public ActionResult Edit (int id )
        {
           return View (_db.GetbyID(id));
        }
        [HttpPost]
        public ActionResult Edit (KitchenDTO kitchenDTO)
        {
            _db.Edit(kitchenDTO);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete (int id)

        {
           return View( _db.GetbyID(id));
            
        }
        [HttpPost,ActionName("Delete")]
        public ActionResult DeleteConfirmed (int id)
        {
            _db.Delete(id);
            return RedirectToAction("Index");

        }
            
    }
}