namespace Monopoly.Controllers
{
    using System.Threading.Tasks;
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Monopoly.BL.Contracts.City;
    using Monopoly.BL.Interfaces;
    using Monopoly.BL.Models.City;

    public class CityController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly ICityService cityService;

        public CityController(IMapper mapper, ICityService cityService)
        {
            this.mapper = mapper;
            this.cityService = cityService;
        }

        [HttpGet(API.Routes.DefaultRoutes.City.GetCity)]
        public async Task<IActionResult> GetCity(int cityId)
        {
            CityModel city = await this.cityService.GetCity(cityId);
            return this.Ok(city);
        }

        [HttpPost(API.Routes.DefaultRoutes.City.AddCity)]
        public async Task<IActionResult> AddCity(CityContract contract)
        {
            CityModel city = await this.cityService.AddCity(contract);
            return this.Ok(city);
        }

        [HttpDelete(API.Routes.DefaultRoutes.City.DeleteCity)]
        public async Task<IActionResult> DeleteCity(int cityId)
        {
            await this.cityService.DeleteCity(cityId);
            return this.Ok();
        }

        [HttpPost(API.Routes.DefaultRoutes.City.AddStreet)]
        public async Task<IActionResult> AddStreet(StreetFieldModel model)
        {
            StreetFieldModel street = await this.cityService.AddStreet(model);
            return this.Ok(street);
        }

        [HttpPost(API.Routes.DefaultRoutes.City.AddStreetMonopoly)]
        public async Task<IActionResult> AddStreetMonopoly(StreetMonopolyModel model)
        {
            StreetMonopolyModel street = await this.cityService.AddStreetMonopoly(model);
            return this.Ok(street);
        }

        [HttpPatch(API.Routes.DefaultRoutes.City.ConnectStreet)]
        public async Task<IActionResult> ConnectStreet(CityStreetContract contract)
        {
            CityStreetModel model = await this.cityService.ConnectStreet(contract);
            return this.Ok(model);
        }

        [HttpDelete(API.Routes.DefaultRoutes.City.DeleteStreet)]
        public async Task<IActionResult> DeleteStreet(int streetId)
        {
            await this.cityService.DeleteStreet(streetId);
            return this.Ok();
        }

        [HttpDelete(API.Routes.DefaultRoutes.City.DeleteStreetMonopoly)]
        public async Task<IActionResult> DeleteStreetMonopoly(int streetMonopolyId)
        {
            await this.cityService.DeleteStreetMonopoly(streetMonopolyId);
            return this.Ok();
        }
    }
}