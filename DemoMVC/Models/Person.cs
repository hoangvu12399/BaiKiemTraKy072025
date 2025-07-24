using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Models;
public class Person : Controller
{
    [Table'Person']
    public class Person()
    {
        [Key]
        public required string PersonId { get; set; }
        public required string FullName { get; set; }
        public required string Diachi { get; set; }
    }
}
