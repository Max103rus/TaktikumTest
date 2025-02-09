using TaktikumTest.Models;

namespace TaktikumTest.Data.Interfaces
{
    public interface IElementsRepository
    {
        public Task ClearTable();

        public Task SaveElementsAsync(List<Element> records);

        public Task<List<Element>> GetElementsAsync(int? code, string? value);
    }
}
