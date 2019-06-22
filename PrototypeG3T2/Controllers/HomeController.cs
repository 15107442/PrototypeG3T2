using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrototypeG3T2.Data;
using PrototypeG3T2.Models;

namespace PrototypeG3T2.Controllers
{
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class HomeController : Controller
    {
        private DataContext _context;

        public HomeController(DataContext context) {

        _context = context;
        }

        public IActionResult Index()
        {
            var list = OrdersKlant(1);
            return View(list);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

     
        //Laat alle orders van 1 klant zien
        [HttpGet]
        public List<Order> OrdersKlant(int KlantId)
        {
            var listOrders = _context.Orders.Where(x => x.KlantId == KlantId).ToList();
            return listOrders;
        }

        //Laat alle data van 1 order zien
        [HttpGet]
        public List<SensorData> SensorDataOrder(int OrderId)
        {
            var listSensorData = _context.SensorDatas.Where(x => x.OrderId == OrderId).ToList();
            return listSensorData;
        }

        //Laat alle orders zien
        [HttpGet]
        public List<Order> alleOrders()
        {
            var listAlleOrders = _context.Orders.Select(x => x).ToList();
            return listAlleOrders;
        }

        //Laat alle klanten zien
        [HttpGet]
        public List<Klant> alleKlanten()
        {
            var listAlleKlanten = _context.Klanten.Select(x => x).ToList();
            return listAlleKlanten;
        }

        //Laat alle data zien
        [HttpGet]
        public List<SensorData> alleSensorData()
        {
            var listAlleSensorData = _context.SensorDatas.Select(x => x).ToList();
            return listAlleSensorData;
        }
    }
}
