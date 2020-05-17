using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Models
{
    public class User : IEntityBase
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string FacebookUrl { get; set; }
        public string LinkedInUrl { get; set; }
        public string InstagramUrl { get; set; }
        public string Password { get; set; }
        public string BriefDescription { get; set; }
        public virtual List<Post> Posts { get; set; }



    }
}
