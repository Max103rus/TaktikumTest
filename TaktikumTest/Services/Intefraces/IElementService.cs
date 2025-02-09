using TaktikumTest.Models;

namespace TaktikumTest.Services.Intefraces
{
    public interface IElementService
    {
        public Task ProcessAndSaveElementsAsync(List<Dictionary<string, string>> inputElements);

        public Task<List<Element>> GetElementsAsync(int? code, string? value);
    }
}
