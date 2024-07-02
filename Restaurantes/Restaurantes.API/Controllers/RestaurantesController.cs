using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurantes.Application.DTOs;
using Restaurantes.Application.Interfaces;
using Restaurantes.Application.Services;
using Restaurantes.Domain.Entities;

namespace Restaurantes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantesController : ControllerBase
    {
        private readonly IRestauranteService _restauranteService;

        public RestaurantesController(IRestauranteService restauranteService)
        {
            _restauranteService = restauranteService;
        }

        [HttpGet]
        public async Task<IEnumerable<RestauranteDTO>> Get()
        {
            var restaurantes = await _restauranteService.GetAll();

            Ok(restaurantes);
            return restaurantes;
        }

        [HttpGet("{id}", Name = "GetRestaurante")]
        public async Task<ActionResult<RestauranteDTO>> Get(int id)
        {
            var restaurante = await _restauranteService.GetById(id);

            if (restaurante == null)
            {
                return NotFound();
            }
            return Ok(restaurante);
        }

        [HttpPost]

        public async Task<ActionResult> Post(RestauranteDTO restauranteDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _restauranteService.Add(restauranteDTO);

            return new CreatedAtRouteResult("GetRestaurante",
                new { id = restauranteDTO.Id }, restauranteDTO);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, RestauranteDTO restauranteDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (id != restauranteDTO.Id)
            {
                return BadRequest();
            }
            await _restauranteService.Update(restauranteDTO);
            return Ok(restauranteDTO);
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<RestauranteDTO>> Delete(int id)
        {
            var usuarioDTO = await _restauranteService.GetById(id);
            if (usuarioDTO == null)
            {
                return NotFound();
            }
            await _restauranteService.Delete(id);
            return Ok(usuarioDTO);
        }

    }
}
