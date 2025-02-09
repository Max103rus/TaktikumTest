using Microsoft.AspNetCore.Mvc;
using TaktikumTest.Services.Intefraces;

namespace TaktikumTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ElementContorller : ControllerBase
    {
        private readonly IElementService _elementService;

        public ElementContorller(IElementService elementService)
        {
            _elementService = elementService;
        }

        [HttpPost]
        public async Task<IActionResult> SaveElements([FromBody] List<Dictionary<string, string>> inputElements)
        {
            try
            {
                await _elementService.ProcessAndSaveElementsAsync(inputElements);
                return Ok("Elements saved successfully");
            }
            catch
            {
                return StatusCode(500);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetElements([FromQuery] int? code, [FromQuery] string? value)
        {
            try
            {
                var elements = await _elementService.GetElementsAsync(code, value);
                return Ok(elements);
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}
