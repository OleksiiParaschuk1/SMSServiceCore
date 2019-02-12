using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using WebCustomerApp.BAL.Interfaces;
using WebCustomerApp.BAL.Repository;
using WebCustomerApp.Data;
using WebCustomerApp.Models;
using WebCustomerApp.Models.MessageViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApp.Controllers
{
    public class MessageController : Controller
    {
        private IUnitOfWork _unitOfWork;

        public MessageController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetMessages()
        {
            ViewBag.Messages = _unitOfWork._messageRepository.GetMessagesBySenderId(_unitOfWork._userManager.GetUserId(User));
            ViewBag.Recepients = _unitOfWork._recepientMessageRepository.GetRecepientsMessagesByMessageId();
            return View();
        }

        [HttpGet]
        public ActionResult AddNewMessage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddNewMessage(MessageModel messageModel)
        {
            Message message = new Message();
            message.SenderId = _unitOfWork._userManager.GetUserId(User);
            message.TextOfMessage = messageModel.TextOfMessage;
            _unitOfWork._messageRepository.Create(message);
            _unitOfWork.SaveChanges();
            return RedirectToAction("GetMessages");
        }


    }
}
