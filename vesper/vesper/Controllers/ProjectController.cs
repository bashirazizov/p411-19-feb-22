using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vesper.DAL;

namespace vesper.Controllers
{
    public class ProjectController : Controller
    {
        private readonly VesperDbContext db;
        public ProjectController(VesperDbContext _db)
        {
            db = _db;
        }

        public IActionResult Index(int id)
        {
            return View(db.Projects.Include(x=>x.ProjectImages).First(x=>x.Id==id));
        }
    }
}
