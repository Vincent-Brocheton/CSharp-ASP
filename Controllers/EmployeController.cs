using Contrat;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetApiAsp.Controllers
{
    [ApiController]
    [Route("api/employes")]
    public class EmployeController : Controller
    {
        private readonly Iloggable _logger;
        private readonly IGestionRepo _repo;
        public EmployeController(Iloggable logger, IGestionRepo repo)
        {
            _logger = logger;
            _repo = repo;
        }

        [HttpGet]
        public IActionResult GetEmployes()
        {
            try
            {
                var employesRepo = _repo.Employes;

                return Ok(employesRepo.GetEmploye(false));
            }
            catch (Exception ex)
            {
                _logger.LogErreur("Erreur dans la récupération des entreprises " + ex);
                return StatusCode(500, "Erreur Serveur");
            }

        }
    }
}
