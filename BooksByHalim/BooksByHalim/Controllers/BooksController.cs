using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BooksByHalim.Data;
using BooksByHalim.Models;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace BooksByHalim.Controllers
{
    public class BooksController : Controller
    {
        private readonly BookDbContext _context;


        public BooksController(BookDbContext context)
        {
            _context = context;
        }

        // GET: Books
        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<Book> obj = _context.Books;
            obj = obj.Where(book => book.Type.Contains("book")).OrderByDescending(book => book.Rating);
            return View(obj);
        }

        // GET: Comics
        [HttpGet]
        public IActionResult IndexComics()
        {
            IEnumerable<Book> obj = _context.Books;
            obj = obj.Where(book => book.Type.Contains("comic")).OrderByDescending(book => book.Rating);
            return View(obj);
        }


        [HttpGet]
     // TODO   [Authorize]
        public IActionResult RateBook(string bookName)
        {
            Book book = _context.Books.Find(bookName);
            return View(book);   
        }


        [HttpPost]
        public IActionResult ChangeRating(Book book)
        {

                Book obj = _context.Books.Find(book.Name);
                double newRate = (obj.Rating + book.Rating) / 2;
                obj.Rating = newRate;
                _context.Books.Update(obj);
                _context.SaveChanges();
                return RedirectToAction("Index");
            
        }


        [HttpPost]
        public IActionResult RateBookCallBack(Book book)
        {
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult FindMethod(string searchTerm)
        {
            StreamWriter sw = new(Url.Content("Properties/Cache/cache.txt"));
            sw.WriteLine(searchTerm);
            sw.Close();

            IEnumerable<Book> obj = _context.Books;

            if (searchTerm == null)
                return RedirectToAction("Index");
            else
            {
                obj = findBooksCollection(obj, searchTerm,false);
                return View(obj);
            }
        }


        [HttpGet]
        public IActionResult FindMethodComics(string searchTerm)
        {
            StreamWriter sw = new(Url.Content("Properties/Cache/cache.txt"));
            sw.WriteLine(searchTerm);
            sw.Close();

            IEnumerable<Book> obj = _context.Books;

            if (searchTerm == null)
                return RedirectToAction("IndexComics");
            else
            {
                obj = findBooksCollection(obj,searchTerm,false);

                return View(obj);
            }
        }


        //Temp function
        public IEnumerable<Book> findBooksCollection(IEnumerable<Book> obj,string searchTerm,Boolean more)
        {
            string[] search = searchTerm.Split(" ");
            string ml = moreOrless(search);
            string strs = stars(search);
            int num = number(search);


            //This can be done with std::less or std::greater
            // TODO Correct with std::less or std::greater
            if (ml.Contains("more") && num != 0)
                obj = getMoreStars(obj, num);
            else if (ml.Contains("less") && num != 0)
                obj = getLessStars(obj, num);
            else if (ml.Contains("newer") && num != 0)
                obj = getNewerThan(obj, num);
            else if (ml.Contains("older") && num != 0)
                obj = getOlderThan(obj, num);
            else if (strs.Contains("star") && num != 0)
                obj = getMoreStars(obj, num);
            else if (num == 0)
                obj = obj.Where(book => book.Name.Contains(searchTerm));

            if (more)
            {
                obj = obj.Concat(obj.Where(book => book.Name.Contains(searchTerm)));
                return obj;
            }
            obj = obj.Take(3);
            return obj;
        }

        //Function concaternate all in search and search by name
        //TODO Make better view for more results
        public IActionResult ShowMeMore()
        {
            StreamReader sw = new(Url.Content("Properties/Cache/cache.txt"));
            string lastSearch = sw.ReadLine();
            sw.Close();

            IEnumerable<Book> obj = _context.Books.Where(model => model.Type.Contains("book"));

            if (lastSearch == null)
                return RedirectToAction("Index");
            else
            {
                obj = findBooksCollection(obj,lastSearch,true);

                return View(obj);
            }
        }

        [HttpGet]
        public IActionResult ShowMeMoreComics()
        {
            StreamReader sw = new(Url.Content("Properties/Cache/cache.txt"));
            string lastSearch = sw.ReadLine();
            sw.Close();

            IEnumerable<Book> obj = _context.Books;

            if (lastSearch == null)
                return RedirectToAction("IndexComics");
            else
            {
                obj = findBooksCollection(obj, lastSearch, true);

                return View(obj);
            }
        }


        /*******  TEMP FUNCTIONS   ***********/

        private IEnumerable<Book> getMoreStars(IEnumerable<Book> obj,int num)
        {
            obj = obj.Where(book => book.Rating>=num);
            return obj;
        }

        private IEnumerable<Book> getNewerThan(IEnumerable<Book> obj, int num)
        {
            obj = obj.Where(book => book.ReleaseDate.Year >= num);
            return obj;
        }

        private IEnumerable<Book> getOlderThan(IEnumerable<Book> obj, int num)
        {
            obj = obj.Where(book => book.ReleaseDate.Year <= num);
            return obj;
        }

        private IEnumerable<Book> getLessStars(IEnumerable<Book> obj, int num)
        {
            obj = obj.Where(book => book.Rating <= num);
            return obj;
        }

        //Function which will find keywords like more,less, older and newer
        private string moreOrless(string []search)
        {
            foreach (string s in search)
                if (s.ToLower().Equals("more") || s.ToLower().Equals("less") || s.ToLower().Equals("older") || s.ToLower().Equals("newer"))
                    return s;
            return "";
        }

        private string stars(string[] search)
        {
            foreach (string s in search)
                if (s.ToLower().Equals("stars") || s.ToLower().Equals("star"))
                    return s;
            return "";
        }

        private int number(string[] search)
        {
            int i = 0;
            foreach (string s in search)
                try
                {
                    i = int.Parse(s);
                }
                catch (Exception e)
                {
                    var msg = e.Message;
                }     
            return i;
        }
    }
}
