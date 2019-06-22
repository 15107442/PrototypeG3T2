using Microsoft.AspNetCore.Mvc;
using PrototypeG3T2.Data;
using PrototypeG3T2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypeG3T2.Controllers
{
    public class DataController : Controller
    {
        private DataContext _context;

        public void SetContext(DataContext context)
        {
            _context = context;
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
