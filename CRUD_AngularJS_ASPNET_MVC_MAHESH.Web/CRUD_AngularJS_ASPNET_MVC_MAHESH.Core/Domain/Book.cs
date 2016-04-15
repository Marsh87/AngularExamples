using System.ComponentModel.DataAnnotations;

namespace CRUD_AngularJS_ASPNET_MVC_MAHESH.Core.Domain
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string Ibsn { get; set; }
    }
}
