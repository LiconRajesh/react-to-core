using Core_To_React_Api.Core.ProjectAggregate;
using Core_To_React_Api.Core.ProjectAggregate.Specifications;
using Core_To_React_Api.SharedKernel.Interfaces;
using Core_To_React_Api.Web.ApiModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using System.Threading.Tasks;

namespace Core_To_React_Api.Web.Pages.ToDoRazorPage
{
    public class IndexModel : PageModel
    {
        private readonly IRepository<Project> _repository;

        [BindProperty(SupportsGet = true)]
        public int ProjectId { get; set; }
        public string Message { get; set; } = "";

        public ProjectDTO Project { get; set; }

        public IndexModel(IRepository<Project> repository)
        {
            _repository = repository;
        }

        public async Task OnGetAsync()
        {
            var projectSpec = new ProjectByIdWithItemsSpec(ProjectId);
            var project = await _repository.GetBySpecAsync(projectSpec);

            if (project == null)
            {
                Message = "No project found.";
                return;
            }

            Project = new ProjectDTO
            {
                Id = project.Id,
                Name = project.Name,
                Items = project.Items
                .Select(item => ToDoItemDTO.FromToDoItem(item))
                .ToList()
            };
        }
    }
}
