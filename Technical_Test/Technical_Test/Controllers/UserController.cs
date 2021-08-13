using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Technical_Test.Models;
using Technical_Test.Models.Repositories;

namespace Technical_Test.Controllers
{
    public class UserController : Controller
    {
        private readonly ITechnicalTest<User> UserRepositories;

        public UserController(ITechnicalTest<User> UserRepositories)
        {
            this.UserRepositories = UserRepositories;

        }
        // GET: UserController
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var user = UserRepositories.Find(id);

            return View(user);


        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Signin(User NewUser, int id)
        {
            var user = UserRepositories.Find(1);
            if (UserRepositories.Signin(user, id) == null)
            {
                return View(user);
            }
            else return View(user);

        }
        // POST: UserController/Create

        [HttpGet]
        public ActionResult Signup(User NewUser)
        {
            try
            {
               
                UserRepositories.Signup(NewUser);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        
            // GET: UserController/Edit/5
            public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
