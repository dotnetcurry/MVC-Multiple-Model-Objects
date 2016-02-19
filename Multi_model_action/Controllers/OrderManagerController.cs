using System.Web.Mvc;
using Multi_model_action.Models;

namespace Multi_model_action.Controllers
{
    public class OrderManagerController : Controller
    {
        ApplicationEntities ctx;

        public OrderManagerController()
        {
            ctx = new ApplicationEntities(); 
        }

        // GET: OrderManager
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public JsonResult SaveOrder(Order order, OrderItemDetails [] orditemdetails)
        {
            ctx.Orders.Add(order);
            foreach (var item in orditemdetails)
            {
                item.OrderId = order.OrderId;
                ctx.OrderItemDetails.Add(item);
            }
            ctx.SaveChanges();
            return Json(true,JsonRequestBehavior.AllowGet);
        }
    }
}