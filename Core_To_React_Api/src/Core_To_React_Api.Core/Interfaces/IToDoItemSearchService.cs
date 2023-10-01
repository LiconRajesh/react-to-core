using Ardalis.Result;
using Core_To_React_Api.Core.ProjectAggregate;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core_To_React_Api.Core.Interfaces
{
    public interface IToDoItemSearchService
    {
        Task<Result<ToDoItem>> GetNextIncompleteItemAsync(int projectId);
        Task<Result<List<ToDoItem>>> GetAllIncompleteItemsAsync(int projectId, string searchString);
    }
}
