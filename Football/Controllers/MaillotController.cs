using Football.Models;
using Microsoft.AspNetCore.Mvc;

namespace Football.Controllers
{
    public class MaillotController : Controller
    {
        private readonly AnnuaireContext _context;

        public MaillotController(AnnuaireContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Maillot> maillots = _context.Maillots.OrderBy(m => m.Id).ThenBy(m => m.Description).ToList();
            return View(maillots);
        }

        public IActionResult Create()
        {
            ViewBag.PaysParticipants = CoupeDuMonde2026.PaysParticipants;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Maillot maillot)
        {
            if (!CoupeDuMonde2026.PaysParticipants.Contains(maillot.Pays))
            {
                ViewBag.PaysParticipants = CoupeDuMonde2026.PaysParticipants;
                ViewBag.Erreur = "Le pays sélectionné n'est pas valide.";
                return View(maillot);
            }

            if (_context.Maillots.Any(m => m.Description.Equals(maillot.Description)))
            {
                ViewBag.PaysParticipants = CoupeDuMonde2026.PaysParticipants;
                ViewBag.Erreur = "Ce maillot existe déjà.";
                return View(maillot);
            }

            _context.Maillots.Add(maillot);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Maillot maillot = _context.Maillots.FirstOrDefault(m => m.Id == id);
            if (maillot == null)
                return NotFound();

            ViewBag.PaysParticipants = CoupeDuMonde2026.PaysParticipants;
            return View(maillot);
        }

        [HttpPost]
        public IActionResult Edit(Maillot maillot)
        {
            if (!CoupeDuMonde2026.PaysParticipants.Contains(maillot.Pays))
            {
                ViewBag.PaysParticipants = CoupeDuMonde2026.PaysParticipants;
                ViewBag.Erreur = "Le pays sélectionné n'est pas valide.";
                return View(maillot);
            }

            Maillot maillotExistant = _context.Maillots.FirstOrDefault(m => m.Id == maillot.Id);
            if (maillotExistant == null)
            {
                ViewBag.PaysParticipants = CoupeDuMonde2026.PaysParticipants;
                ViewBag.Erreur = "Ce maillot n'existe pas.";
                return View(maillot);
            }

            maillotExistant.Description = maillot.Description;
            maillotExistant.Couleur = maillot.Couleur;
            maillotExistant.Taille = maillot.Taille;
            maillotExistant.Prix = maillot.Prix;
            maillotExistant.Pays = maillot.Pays;

            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Maillot maillot = _context.Maillots.FirstOrDefault(m => m.Id == id);
            if (maillot == null)
                return NotFound();

            return View(maillot);
        }

        [HttpPost]
        public IActionResult Delete(Maillot maillot)
        {
            Maillot maillotExistant = _context.Maillots.FirstOrDefault(m => m.Id == maillot.Id);
            if (maillotExistant == null)
            {
                ViewBag.Erreur = "Ce maillot n'existe pas.";
                return View(maillot);
            }

            _context.Maillots.Remove(maillotExistant);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Maillot maillot = _context.Maillots.FirstOrDefault(m => m.Id == id);
            if (maillot == null)
                return NotFound();

            return View(maillot);
        }
    }
}
