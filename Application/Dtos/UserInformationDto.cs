using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dtos
{
    public class UserInformationDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string FacebookUrl { get; set; }
        public string LinkedInUrl { get; set; }
        public string InstagramUrl { get; set; }
        public string BriefDescription { get; set; }
    }
}
