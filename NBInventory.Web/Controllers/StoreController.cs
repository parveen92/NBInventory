using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NBInventory.DTO;
using NBInventory.Services.IServices;
using NBInventory.Services.Services;

namespace NBInventory.Web.Controllers
{
    public class StoreController : Controller
    {
        private readonly IStoreServices _storeServices;
        public StoreController()
        {
            _storeServices = new StoreServices();
        }

        // GET: Store
        public ActionResult Index()
        {
            return View(_storeServices.GetStores());
        }

        //Create Store Get Page Open
        [HttpGet]
        public ActionResult Create()
        {


            return View();
        }

        //Create Store Post Save Button.
        [HttpPost]
        public ActionResult Create(StoreDTO storeDTO)
        {
            _storeServices.Create(storeDTO);

            return RedirectToAction("Index");
        }

        //Edit Store Get Page Open With All Store List
        [HttpGet]
        public ActionResult Edit(int id)
        {

            return View(_storeServices.GetbyID(id));
        }


        //Edit Store Post Save Button for Edit Page.
        [HttpPost]
        public ActionResult Edit(StoreDTO storeDTO)
        {
            _storeServices.Edit(storeDTO);

            return RedirectToAction("Index");
        }

        //Delete Store Get Page Open
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var store = _storeServices.GetbyID(id);
            if (store == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            else
            {
                return View(store);
            }
        }


        //Delete Store Post Delete Confirm Button
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            bool i = _storeServices.Delete(id);
            if (i == true)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }

        }




    }
}