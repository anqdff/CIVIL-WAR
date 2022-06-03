using CIVIL_WAR.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CIVIL_WAR.Controllers
{
    public class AjoutArmeController : Controller
    {
        private ApplicationDbContext Context { get; set; }
        public AjoutArmeController(ApplicationDbContext _context)
        {
            this.Context = _context;
        }
        // POST: AjoutArmeController/Create
        [HttpPost]
        [Route("Create")]
        public IActionResult Create(Arme model)
        {
            this.Context.ArmeModel.Add(model);
            this.Context.SaveChanges();
            return Ok(new Reponse { Status = "Success", Message = "Arme Ajoutée" }); 
        }

        //Get: Get de la liste des armes
        [HttpGet]
        [Route("Read")]
        public async Task<IActionResult> GetGunList()
        {
            var arme = Context.ArmeModel.ToList();
            return Ok(arme);
        }

        //Post: Modifier une arme par son son id
       [HttpPost]
       [Route("Update")]
       public ActionResult EditGun(int ArmeId,String Name)
       {
            Arme armeUpdate = new Arme();
            armeUpdate = Context.ArmeModel.Find(ArmeId);
            //armeUpdate.Name = "Test";
            armeUpdate.Name = Name;
            Context.Entry(armeUpdate).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Context.SaveChanges();
            return Ok(new Reponse { Status = "200", Message = "Arme modifiée" });
        }
    }
}
