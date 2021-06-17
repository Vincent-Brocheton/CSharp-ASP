using AutoMapper;
using Contrat;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Entities.DTO;
using System.Linq;
using Entities;

namespace projetApiAsp.Controllers
{
    [ApiController]
    [Route("api/entreprises")]
    public class EntreprisesController : ControllerBase
    {
        private readonly Iloggable _logger;
        private readonly IGestionRepo _repo;
        private readonly IMapper _mapper;
        public EntreprisesController(Iloggable logger, IGestionRepo repo, IMapper mapper)
        {
            _mapper = mapper;
            _logger = logger;
            _repo = repo;
        }

        [HttpGet]
        public IActionResult GetEntreprises()
        {
            try
            {
                var entreprisesRepo = _repo.Entreprises;

                var entreprises = entreprisesRepo.GetEntreprises(false);

                var entreprisesDto = _mapper.Map<IEnumerable<EntrepriseDto>>(entreprises);

                //var entreprisesDto = entreprises.Select(elt => _mapper.Map<EntrepriseDto>(elt)).ToList();

                return Ok(entreprisesDto);
            }
            catch(Exception ex)
            {
                _logger.LogErreur("Erreur dans la récupération des entreprises " + ex);
                return StatusCode(500, "Erreur Serveur");
            }
            
        }
    }
}
