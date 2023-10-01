using Core_To_React_Api.Core.ProjectAggregate;
using Core_To_React_Api.SharedKernel;

namespace Core_To_React_Api.Core.ProjectAggregate.Events
{
    public class ToDoItemCompletedEvent : BaseDomainEvent
    {
        public ToDoItem CompletedItem { get; set; }

        public ToDoItemCompletedEvent(ToDoItem completedItem)
        {
            CompletedItem = completedItem;
        }
    }
}