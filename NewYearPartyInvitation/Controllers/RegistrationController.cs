using NewYearPartyInvitation.Models.DataAccess;
using NewYearPartyInvitation.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewYearPartyInvitation.Controllers
{

    public class RegistrationController : Controller
    {
        IGuestRepository guestRepository = new GuestRepository();

        // GET: Registration
        [HttpGet]
        public ActionResult Register()
        {
            // return view for collecting he registration details
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(GuestInfo guestInfo)
        {
            // Step 1: reveive Registration Details

            // Model 1 : Use Request Object
            // using Request Object
            // string gname = Request["name"];


            // Model 2 : use FormCollection
            // provide function Paramater : FormCollection input
            //var age = input["age"];

            // ******************** Best Way ********************8
            // Model 3 : Common Agreement/contract 
            //           between Controller and View Developer
            //           ie. GuestInfo here
            //           Controller and View, Uses Common Names
            // ModelBinder fills The information into GuestInfo Object

            // Step 2 : Save the data to DB

            // if any rule has been violated
            // by Model Binder
            // while taking the information from View
            if (ModelState.IsValid)
            {
                guestRepository.SaveGuest(guestInfo);
                ViewBag.Guest = guestInfo;

                return View("Thanks");
            }
            else
            {
                return View();
            }
        }

        public ActionResult List()
        {
            ViewBag.GuestList = guestRepository.GetAllGuests();
            return View();
        }
    }
}