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
    public class RoomItemDetailController : Controller
    {
        private readonly IRoomItemDetailServices _db;
        private readonly IRoomServices _dbroom;
        private readonly IStoreServices _dbstore;
        private readonly IStockItemServices _dbstockitem;
        public RoomItemDetailController()
        {
            _db = new RoomItemDetailServices();
            _dbroom = new RoomServices();
            _dbstore = new StoreServices();
            _dbstockitem = new StockItemServices();
        }

        // GET: RoomItemDetail
        public ActionResult Index()
        {
            return View(_db.GetRoomItemDetails());
        }

        //GET: Create RoomItemDetail
        [HttpGet]
        public ActionResult Create()
        {
            var room = _dbroom.GetRooms();
            ViewBag.Room = new SelectList(room, "Room_NumberID", "Room_Type");

            var store = _dbstore.GetStores();
            ViewBag.Store = new SelectList(store, "Store_ID", "Store_Name");

            var stockitem = _dbstockitem.GetStockItems();
            ViewBag.StockItem = new SelectList(stockitem, "Item_ID", "Item_Name");

            return View();

        }

        //POST: Create RoomItemDetail
        [HttpPost]
        public ActionResult Create(RoomItemDetailDTO roomItemDetailDTO)
        {
            _db.Create(roomItemDetailDTO);
            return RedirectToAction("Index");
        }

        //Trial Code
        public ActionResult GetItemsbyStore(int id)
        {
            List<SelectListItem> items = new List<SelectListItem>();
            items.Add(new SelectListItem() { Text = "Sub Item 1", Value = "1" });
            items.Add(new SelectListItem() { Text = "Sub Item 2", Value = "8" });
            // you may replace the above code with data reading from database based on the id

            return Json(items, JsonRequestBehavior.AllowGet);
        }


    }
}