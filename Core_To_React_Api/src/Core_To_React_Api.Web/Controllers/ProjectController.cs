using Core_To_React_Api.Core;
using Core_To_React_Api.Core.ProjectAggregate;
using Core_To_React_Api.Core.ProjectAggregate.Specifications;
using Core_To_React_Api.SharedKernel.Interfaces;
using Core_To_React_Api.Web.ApiModels;
using Core_To_React_Api.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Core_To_React_Api.Web.Controllers
{
    [Route("[controller]")]
    public class ProjectController : Controller
    {
        private readonly IRepository<Project> _projectRepository;

        public ProjectController(IRepository<Project> projectRepository)
        {
            _projectRepository = projectRepository;
        }

        // GET project/{projectId?}
        [HttpGet("{projectId:int}")]
        public async Task<IActionResult> Index(int projectId = 1)
        {
            var spec = new ProjectByIdWithItemsSpec(projectId);
            var project = await _projectRepository.GetBySpecAsync(spec);

            var dto = new ProjectViewModel
            {
                Id = project.Id,
                Name = project.Name,
                Items = project.Items
                            .Select(item => ToDoItemViewModel.FromToDoItem(item))
                            .ToList()
            };
            return View(dto);
        }
    }
}
