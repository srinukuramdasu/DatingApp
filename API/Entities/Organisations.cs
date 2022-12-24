

using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class Organisations
    {
        [Key]
        public int OrganisationID { get; set; }
         public string  OrganisationCode { get; set; }
        public string  OrganisationName { get; set; }
    }
}