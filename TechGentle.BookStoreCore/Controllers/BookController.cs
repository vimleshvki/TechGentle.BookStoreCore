using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TechGentle.BookStoreCore.Controllers
{
    public class BookController : Controller
    {
        public string GetAllBooks()
        {
            return "all books";
        }
    }
}