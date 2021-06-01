using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseLibrary.API.Models
{
    public class CourseForCreationDto
    {
        public string Title { get; set; }

        public string Description { get; set; }

        // this is comes with route URL
        // public Guid AuthorId { get; set; }
        // [Route("api/authors/{authorId}/courses")]

    }
}
