using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NBInventory.Services.IServices;
using NBInventory.Services.Services;
using NBInventory.DTO;

namespace NBInventory.Web.Controllers
{
    public class RoomController : Controller
    {
        private readonly IRoomServices _db;
        public RoomController()
        {
            _db = new RoomServices();
        }

        // GET: Room
        public ActionResult Index()
        {
            return View(_db.GetRooms());
        }

        //GET: Create Room
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        //GET: Create Room
        [HttpPost]
        public ActionResult Create(RoomDTO roomDTO)
        {
            _db.Create(roomDTO);
            return RedirectToAction("Index");
        }

        //GET: Edit Room
        [HttpGet]
        public ActionResult Edit(int id )
        {
            return View(_db.GetbyID(id));
        }
        
        //POST: Edit Room Save Button
        [HttpPost]
        public ActionResult Edit(RoomDTO roomDTO)
        {
            _db.Edit(roomDTO);
            return RedirectToAction("Index");
        }


        //GET: Delete Room
        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(_db.GetbyID(id));
        }

        //POST: Delete Room Delete Button
        [HttpPost,ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            _db.Delete(id);
            return RedirectToAction("Index");
        }

    }
}