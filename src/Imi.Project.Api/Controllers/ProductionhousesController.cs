using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Imi.Project.Api.Core.Interfaces.Services;
using Imi.Project.Api.Core.Dtos;

namespace Imi.Project.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductionhousesController : ControllerBase
    {
        private readonly IProductionhouseService _productionhouseService;

        public ProductionhousesController(IProductionhouseService productionhouseService)
        {
            _productionhouseService = productionhouseService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var productionhouses = await _productionhouseService.ListAllAsync();
            return Ok(productionhouses);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var productionhouses = await _productionhouseService.GetByIdAsync(id);
            if (productionhouses == null)
            {
                return NotFound($"The Productionhouse with ID {id} does not exist");
            }

            return Ok(productionhouses);
        }

        [HttpPost]
        public async Task<IActionResult> Post(ProductionhouseRequestDto productionhouseRequestDto)
        {
            var productionHouseResponseDto = await _productionhouseService.AddAsync(productionhouseRequestDto);
            return CreatedAtAction(nameof(Get), new { id = productionHouseResponseDto.Id }, productionHouseResponseDto);
        }

        [HttpPut]
        public async Task<IActionResult> Put(ProductionhouseRequestDto productionhouseRequestDto)
        {
            var productionhouseResponseDto = await _productionhouseService.UpdateAsync(productionhouseRequestDto);

            return Ok(productionhouseResponseDto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var artist = _productionhouseService.GetByIdAsync(id);

            if (artist == null)
            {
                return NotFound($"The productionhouse with ID {id} does not exist");
            }

            await _productionhouseService.DeleteAsync(id);

            return Ok();
        }

    }
}
