using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BazaFilmów.Models;
using System.Data.Entity;
using PagedList;

namespace BazaFilmów.Controllers
{
    public class HomeController : Controller
    {
        private FilmyEntities2 _db = new FilmyEntities2();
       
        // GET: Home
        public ActionResult Index(string findFilm, string sortowanie, int? page)
        {
            ViewBag.SortBy = sortowanie;
            ViewBag.SortByTytuł = sortowanie == null ? "Tytuł_Malejaco" : "";
            ViewBag.SortByReżyser = sortowanie == "Reżyser_Malejaco" ? "Reżyser_Rosnaco" : "Reżyser_Malejaco";
            ViewBag.SortByData = sortowanie == "Data_malejąco" ? "Data_rosnąco" : "Data_malejąco";

         


            var film = from i in _db.Filmy select i;

            //jeśli coś przesłano, to wyszukaj po tym

            if (!String.IsNullOrEmpty(findFilm))
            {
                film = from i in _db.Filmy
                       where i.tytuł.Equals(findFilm) || i.reżyser.Equals(findFilm)
                       select i;
            }

            switch (sortowanie)
            {
                case "Tytuł_Malejaco":
                    film = film.OrderByDescending(s => s.tytuł);
                    break;
                case "Reżyser_Malejaco":
                    film = film.OrderByDescending(s => s.reżyser);
                    break;
                case "Reżyser_Rosnaco":
                    film = film.OrderBy(s => s.reżyser);
                    break;
                case "Data_malejąco":
                     film = film.OrderByDescending(s => s.data_premiery);
                    break;
                case "Data_rosnąco":
                    film = film.OrderBy(s => s.data_premiery);
                    break;
                default:
                   film= film.OrderBy(s => s.tytuł);
                    break;
            }
        
          
            int pageSize = 7;
            int pageNumber = (page ?? 1);
            
            
            return View(film.ToPagedList(pageNumber, pageSize));
        }
        
        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            var movieToEdit = (from Filmy in _db.Filmy where Filmy.ID == id select Filmy).First();
            return View(movieToEdit);
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(Models.Filmy nwMovie)
        {
            if (ModelState.IsValid)
            {
                Models.Filmy nowy = nwMovie;
                _db.Filmy.Add(nowy);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            var movieToEdit = (from Filmy in _db.Filmy where Filmy.ID== id select Filmy).First();
            return View(movieToEdit);
        }
        //
        // POST: /Home/Edit/5
        [HttpPost]
        public ActionResult Edit(Filmy movieToEdit)
        {
            var originalMovie = (from Filmy in _db.Filmy
                                 where Filmy.ID == movieToEdit.ID
                                 select Filmy).First();
            
            _db.Entry(originalMovie).CurrentValues.SetValues(movieToEdit);
            _db.SaveChanges();
            
            return RedirectToAction("Index");
        }

      

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            var movieToEdit = (from Filmy in _db.Filmy where Filmy.ID == id select Filmy).First();
            return View(movieToEdit);
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(Models.Filmy movieToDelete)
        {
            var SelMovie = (from Filmy in _db.Filmy
                            where Filmy.ID == movieToDelete.ID
                            select Filmy).First();
            _db.Filmy.Remove(SelMovie);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
