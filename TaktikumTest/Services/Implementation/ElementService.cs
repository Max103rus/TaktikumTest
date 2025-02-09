using TaktikumTest.Data.Interfaces;
using TaktikumTest.Models;
using TaktikumTest.Services.Intefraces;

namespace TaktikumTest.Services.Implementation

{
    public class ElementService : IElementService
    {
        private readonly IElementsRepository _elementsRepository;

        public ElementService(IElementsRepository elementsRepository)
        {
            _elementsRepository = elementsRepository;
        }

        public async Task ProcessAndSaveElementsAsync(List<Dictionary<string, string>> inputElements)
        {
            var processedElements = inputElements
                .SelectMany(dict => dict
                    .Where(pair => int.TryParse(pair.Key, out _))
                    .Select(pair => new Element
                    {
                        Code = int.Parse(pair.Key),
                        Value = pair.Value
                    }))
                .OrderBy(item => item.Code)
                .ToList();

            if (processedElements.Any())
            {
                await _elementsRepository.ClearTable();
                await _elementsRepository.SaveElementsAsync(processedElements);
            }
        }

        public async Task<List<Element>> GetElementsAsync(int? code, string? value)
        {
            return await _elementsRepository.GetElementsAsync(code, value);
        }
    }
}
