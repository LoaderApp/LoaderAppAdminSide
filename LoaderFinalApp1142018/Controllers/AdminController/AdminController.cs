using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoadProject.Controllers.AdminController
{
    public class AdminController : Controller
    {
        // GET: AdminMain
        public ActionResult AdminMain()
        {
            //Session["SignIn"] = false;
            if (Session["SignIn"]!=null)
            {
                return View();
            }
            return RedirectToAction("viewAvailableOrders");
        }


        public ActionResult viewAvailableOrders()
        {
            Session["SignIn"] = true;
            var listOfOrders = new List<Order>();
            listOfOrders.Add(new Order()
            {
                Id=1,
                ClientId=2,
                TransportOwnerId=3,
                OrderPickup="Lahore",
                OrderDropOff="Multan",
                OrderComodity="",
                OrderWeight="",
            });
            // AllOrderS From Order Table
            ViewBag.OrderData = listOfOrders;
            return View();
        }

        public ActionResult viewAvailableQuotes()
        {
            var listOfOrders = new List<Order>();
            listOfOrders.Add(new Order()
            {
                Id = 1,
                ClientId = 2,
                TransportOwnerId = 3,
                OrderPickup = "Lahore",
                OrderDropOff = "Multan",
                OrderComodity = "",
                OrderWeight = "",
            });
            // AllOrderS From Order Table
            ViewBag.QuotesData = listOfOrders;
            return View();
            
        }

        public ActionResult viewQuoteDetails(int id)
        {

            return View();
        }
        public ActionResult AcceptQuote()
        {

            return View();
        }

        public ActionResult updateOrderAsConfirmedToTransportOwner()
        {

            return View();
        }

        public ActionResult changeStatusToTransit()
        {

            return View();
        }

        public ActionResult changeStatusToCompleted()
        {

            return View();
        }



    }

    public partial class Order
    {
        public int Id { get; set; }
        public Nullable<int> ClientId { get; set; }
        public Nullable<int> TransportOwnerId { get; set; }
        public string OrderPickup { get; set; }
        public string OrderDropOff { get; set; }
        public string OrderComodity { get; set; }
        public string OrderWeight { get; set; }
        public Nullable<System.DateTime> OrderPickUpDate { get; set; }
        public string OrderLength { get; set; }
        public string OrderWidth { get; set; }
        public string OrderHeight { get; set; }
        public string OrderReceiverName { get; set; }
        public string OrderReceiverCompanyName { get; set; }
        public string OrderAdditionalDetails { get; set; }
        public string OrderStatus { get; set; }
        public string OrderBudget { get; set; }

    }
}