using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NBInventory.Services.Services;
using NBInventory.Services.IServices;
using NBInventory.Services;
using NBInventory.DTO;

namespace NBInventory.Web.Controllers
{
    public class StockItemController : Controller
    {
        private readonly IStockItemServices _db;
        private readonly IStoreServices _dbstore;
        public StockItemController()
        {
            _db = new StockItemServices();
            _dbstore = new StoreServices();
        }

        // GET: StockItem
        public ActionResult Index()
        {
            return View(_db.GetStockItems());
        }

        //GET: Create StockItem
        [HttpGet]
        public ActionResult Create()
        {
            
            var store=_dbstore.GetStores();
            ViewBag.Storename = new SelectList(store, "Store_ID", "Store_Name");

            

            return View();
        }

        //POST: Create StockItem Save Button
        [HttpPost]
        public ActionResult Create(StockItemDTO stockItemDTO)
        {
            _db.Create(stockItemDTO);
            return RedirectToAction("Index");
        }


        //GET: Edit StockItem
        public ActionResult Edit(int id)
        {
            return View(_db.GetbyID(id));
        }

        //POST: Edit StockItem Save Button
        [HttpPost]
        public ActionResult Edit(StockItemDTO stockItemDTO)
        {
            _db.Edit(stockItemDTO);
            return RedirectToAction("Index");
        }

        //GET: Delete StockItem
        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(_db.GetbyID(id));
        }

        //POST: Delete StockItem Delete Button
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            _db.Delete(id);
            return RedirectToAction("Index");
        }


    }
}