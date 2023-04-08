using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace MyNewMVC.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(80, ErrorMessage = "Name should be max 80 character")]

        public string Name { get; set; }

        [Required]
        public string Class { get; set; }

        [Required]
        public string Gender { get; set; }

        [Display(Name = "Department")]
        public virtual int DeptID { get; set; }

        [ForeignKey("DeptID")]

        public virtual Department? Department { get; set; }
    }
}
