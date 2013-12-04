using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.Models;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        private MusicStoreEntities storeDB = new MusicStoreEntities();
        //
        // GET: /Store/
        /*public string Index()
        {
            return "Hello from Store.Index()";
        }*/
        public ActionResult Index()
        {
           /*var genres = new List<Genre>{
                new Genre{Name="Disco"}, new Genre{Name="Jazz"},new Genre{Name="Rock"}
            };*/
            var genres = storeDB.Genres.ToList();

            return View(genres);
        }


        //
        // GET: /Store/Browse
        /*public string Browse(string genre)
        {
            return HttpUtility.HtmlEncode("Store.Brower,Genre ="+genre);
        //    return "Hello from Store.Browse()";
        }*/

        public ActionResult Browse(string genre)
        {
            // Retrieve Genre and its Associated Albums from database
            var genreModel = storeDB.Genres.Include("Albums")
                .Single(g => g.Name == genre);

            return View(genreModel);
        }


        //
        // GET: /Store/Details
        /*public string Details()
        {
            return "Hello from Store.Details()";
        }*/

        // GET: /Store/Details/5
        /*public string Details(int id)
        {
            string message = "Store.Details, ID = " + id;

            return message;
        }*/
        public ActionResult Details(int id)
        {
            //var album = new Album { Title = "Album" + id };
            var album = storeDB.Albums.Find(id);
            return View(album);
        }

    }
}
