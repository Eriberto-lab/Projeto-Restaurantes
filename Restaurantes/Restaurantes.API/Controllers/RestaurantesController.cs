using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurantes.Application.DTOs;
using Restaurantes.Application.Interfaces;

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
    }
}
