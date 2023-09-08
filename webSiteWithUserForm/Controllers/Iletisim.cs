using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using webSiteWithUserForm.Models;


namespace webSiteWithUserForm.Controllers
{
    public class Iletisim : Controller
    {
        private readonly DatabaseDbContext _context; // DbContext nesnesi

        public Iletisim (DatabaseDbContext context)
        {
            _context = context;
        }
 
        public IActionResult Index()
        {

            var visiterList = _context.VisitersList.ToList();
            return View(visiterList);

            
        }

        public IActionResult Delete(int id)
        {
            var visiter = _context.VisitersList.FirstOrDefault(s => s.Id == id);
            if (visiter == null)
            {
                return NotFound();
            }
            return View(visiter);
        }

        [HttpPost]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var visiter = _context.VisitersList.FirstOrDefault(s => s.Id == id);
            
                _context.VisitersList.Remove(visiter);
                _context.SaveChanges();
            
            return RedirectToAction("Index");
        }

        ////[HttpDelete]
        //public IActionResult Delete(int id)
        //{
        //    var visiter = _context.VisitersList.FirstOrDefault(s => s.Id == id);
        //    if (visiter == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(visiter);
        //}


        //[HttpDelete]
        //public IActionResult DeleteConfirmed(int id)
        //{
        //    var visiter = _context.VisitersList.FirstOrDefault(s => s.Id == id);
        //    if (visiter != null)
        //    {
        //        _context.VisitersList.Remove(visiter);
        //        _context.SaveChanges();
        //    }
        //    return RedirectToAction("Listele");
        //}






        //[HttpPost]

        //public IActionResult Index(IFormCollection form)

        //{

        //    if (ModelState.IsValid)
        //    {
        //        // Verileri DbContext'e ekleyin ve kaydedin
        //        string name = form["Name"];
        //        string surname = form["Surname"];
        //        string email = form["Email"];
        //        string message = form["Message"];
        //        Visiter savedVisiter = new Visiter();
        //        {
        //            savedVisiter.Name = name;
        //            savedVisiter.Surname = surname;
        //            savedVisiter.Email = email;
        //            savedVisiter.Message = message;





        //        };

        //        _context.VisitersList.Add(savedVisiter);
        //        _context.SaveChanges();

        //        // Başarılı kayıt sonrası bir işlem yapabilirsiniz, örneğin başka bir sayfaya yönlendirme
        //        return RedirectToAction("Index");
        //    }

        //    // Model geçerli değilse formu tekrar gösterin

        //    return View();  
        //}

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Visiter visiter)
        {
            if (ModelState.IsValid)
            {
                _context.VisitersList.Add(visiter);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(visiter);
        }

        public IActionResult Edit(int id)
        {
            var visiter = _context.VisitersList.FirstOrDefault(s => s.Id == id);
            if (visiter == null)
            {
                return NotFound();
            }
            return View(visiter);
        }

        [HttpPost]
        public IActionResult Edit(Visiter visiter)
        {
            if (ModelState.IsValid)
            {
                _context.VisitersList.Update(visiter);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(visiter);
        }


        public IActionResult Details(int id)
        {
            var visiter = _context.VisitersList.FirstOrDefault(s => s.Id == id);
            if (visiter == null)
            {
                return NotFound(); // Öğrenci bulunamazsa 404 hatası döndürün
            }
            return View(visiter);
        }

    }
}
