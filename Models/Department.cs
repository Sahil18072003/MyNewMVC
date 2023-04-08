using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyNewMVC.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? DeptName { get; set; }
    }
}
