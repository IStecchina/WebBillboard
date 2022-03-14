using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBillboard.Abstract;

namespace WebBillboard.Controllers
{
    public class MessagesController : Controller
    {
        private readonly IMessageGateway _gateway;
        public MessagesController(IMessageGateway gateway)
        {
            _gateway = gateway;
        }

        public IActionResult Index()
        {
            var messages = _gateway.GetMessages();
            return View(messages);
        }

        public IActionResult Detail(int id)
        {
            var message = _gateway.GetMessage(id);
            return View(message);
        }

        public IActionResult Delete(int id)
        {
            _gateway.DeleteMessage(id);
            return RedirectToAction("Index");
        }
    }
}
