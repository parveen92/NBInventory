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
    public class KitchenItemDetailController : Controller
    {
        private readonly IKitchenItemDetailServices _dbKitchenitem;
        private readonly IKitchenServices _dbkitchen;
        private readonly IStoreServices _dbstore;
        private readonly IStockItemServices _dbstockitem;
        public KitchenItemDetailController()
        {
            _dbKitchenitem = new KitchenItemDetailServices();
            _dbstore = new StoreServices();
            _dbkitchen = new KitchenServices();
            _dbstockitem = new StockItemServices();
        }
        // GET: KitchenItemDetail
        public ActionResult Index()
        {
            return View(_dbKitchenitem.GetKitchenItemsDetails());
        }
        [HttpGet]
        public ActionResult Create()
        {


            return View();
        }
        [HttpPost]
        public ActionResult Create(KitchenItemDetailDTO kitchenItemDetailDTO)
        {
            _dbKitchenitem.Create(kitchenItemDetailDTO);
            return RedirectToAction("Index");
        }
    }
}