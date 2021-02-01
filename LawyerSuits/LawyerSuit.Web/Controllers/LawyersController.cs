using LawyerSuits.DAL;
using LawyerSuits.Domain;
using LawyerSuits.Domain.Enum;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LawyerSuits.Services.EmailService;

namespace LawyerSuits.Web.Controllers
{
    //[Route("api/[LawyersController]")]
    public class LawyerController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private LawyerSuitsDbContext _db;
        private IEmailService _emailService;
        public LawyerController(ILogger<HomeController> logger, LawyerSuitsDbContext db, IEmailService emailService)
        {
            _logger = logger;
            _db = db;
            _emailService = emailService;
        }
        //[Route("/Lawyers")]
        public IActionResult Index()
        {
            return View(_db.Lawyers.AsEnumerable());
        }
        //[Route("/Lawyers/Create")]
        public IActionResult Create()
        {
            return View(new Lawyer());
        }
        [HttpPost]
        public IActionResult Create(Lawyer model)
        {
            if (ModelState.IsValid)
            {
                model.DateCreated = DateTime.Now;
                model.LastModified = DateTime.Now;
                _db.Add(model);
                _db.SaveChanges();
                return RedirectToAction();
            }
            return View(model);
        }
        public IActionResult Edit(int Id)
        {
            return View(_db.Lawyers.FirstOrDefault(a => a.Id == Id)); 
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Lawyer model)
        {
            if (ModelState.IsValid)
            {
                var editModel = _db.Lawyers.Find(model.Id);
                editModel.LawyerName = model.LawyerName;
                editModel.LawyerCPF = model.LawyerCPF;
                editModel.LawyerOABOrder = model.LawyerOABOrder;
                editModel.OccupationArea = model.OccupationArea;
                editModel.IsActive = model.IsActive;
                if (editModel.IsActive)
                {
                    editModel.LastModified = DateTime.Now;
                    await _emailService.SendEmailAsync("JohnDoe@test.com", "JaneDoe@test.com", "Lawyer Was Registered", $"Task {editModel.Id} Was Registered on {DateTime.Now}");
                }
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        //[Route("Lawyers/Delete/{id:int}")]
        public IActionResult Delete(int Id)
        {
            return View(_db.Lawyers.FirstOrDefault(a => a.Id == Id));
        }

        [HttpPost]
        public IActionResult Delete(Lawyer model)
        {
            var deleteModel = _db.Lawyers.Find(model.Id);
            _db.Remove(deleteModel);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
