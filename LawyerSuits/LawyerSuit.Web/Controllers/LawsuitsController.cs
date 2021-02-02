using LawyerSuits.DAL;
using LawyerSuits.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LawyerSuits.Services.EmailService;

namespace LawyerSuits.Web.Controllers
{
    public class LawsuitsController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private LawyerSuitsDbContext _db;
        private IEmailService _emailService;
        public LawsuitsController(ILogger<HomeController> logger, LawyerSuitsDbContext db, IEmailService emailService)
        {
            _logger = logger;
            _db = db;
            _emailService = emailService;
        }
        public IActionResult Index()
        {
            return View(_db.Lawsuits.AsEnumerable());
        }

        public IActionResult Create()
        {
            return View(new SuitItem());
        }
        [HttpPost]
        public IActionResult Create(SuitItem model)
        {
            if (ModelState.IsValid)
            {
                model.DateCreated = DateTime.Now;
                model.LastModified = DateTime.Now;
                _db.Add(model);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Edit(int Id)
        {
            return View(_db.Lawsuits.FirstOrDefault(a => a.Id == Id)); 
        }

        [HttpPost]
        public async Task<IActionResult> Edit(SuitItem model)
        {
            if (ModelState.IsValid)
            {
                var editModel = _db.Lawsuits.Find(model.Id);
                editModel.SuitName = model.SuitName;
                editModel.SuitDescription = model.SuitDescription;
                editModel.IsCompleted = model.IsCompleted;
                if (editModel.IsCompleted)
                {
                    editModel.LastModified = DateTime.Now;
                    //await _emailService.SendEmailAsync("JohnDoe@test.com", "JaneDoe@test.com", "Lawsuit Was Completed", $"Task {editModel.Id} Was Completed on {DateTime.Now}");
                }
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Delete(int Id)
        {
            return View(_db.Lawsuits.FirstOrDefault(a => a.Id == Id));
        }

        [HttpPost]
        public IActionResult Delete(SuitItem model)
        {
            var deleteModel = _db.Lawsuits.Find(model.Id);
            _db.Remove(deleteModel);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
