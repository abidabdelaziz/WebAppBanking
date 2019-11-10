using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Models;
using Models.Repositories;

namespace WebApplication1.Controllers
{
  
    public class AccountController : Controller
    {
        private readonly IAccountRepository _repo;

        public AccountController (IAccountRepository repo)
        {
            _repo = repo;
        }

        // GET: Customers
        public async Task<IActionResult> Index()
        {
            return View(await _repo.Get());
        }

        // GET: Account/Details/id
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _repo.Get(id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // GET: Account/Create
        public IActionResult Create()
        {
            // Look into why this wasnt working
            //List<string> AccTypes = new List<string>() { "Checking", "Banking", "Loan", "CD" };
            //ViewBag.AccountTypes = new SelectList(AccTypes, "ID", "FullName");

            return View(new Account());
        }

        // POST: Account/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( Account account)
        {

           
            if (ModelState.IsValid)
            {
                await _repo.Create(account);

                return RedirectToAction(nameof(Index));
            }
            return View(account);
        }


        // GET: Account/Delete/id
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _repo.Get(id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // POST: Account/Delete/id
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var isDeleted = await _repo.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        private bool AccountExists(int id)
        {
            return _repo.AccountExists(id);
        }

    }
}