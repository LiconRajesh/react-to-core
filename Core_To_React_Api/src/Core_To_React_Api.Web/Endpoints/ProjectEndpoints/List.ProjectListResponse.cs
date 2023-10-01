using Core_To_React_Api.Core.ProjectAggregate;
using System.Collections.Generic;

namespace Core_To_React_Api.Web.Endpoints.ProjectEndpoints
{
    public class ProjectListResponse
    {
        public List<ProjectRecord> Projects { get; set; } = new();
    }
}
