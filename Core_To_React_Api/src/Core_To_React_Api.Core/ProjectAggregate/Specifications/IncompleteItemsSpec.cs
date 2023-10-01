using Ardalis.Specification;

namespace Core_To_React_Api.Core.ProjectAggregate.Specifications
{
    public class IncompleteItemsSpec : Specification<ToDoItem>
    {
        public IncompleteItemsSpec()
        {
            Query.Where(item => !item.IsDone);
        }
    }
}
