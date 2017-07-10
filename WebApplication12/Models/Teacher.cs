//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication12.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Teacher
    {
        public Teacher()
        {
            this.Students = new HashSet<Student>();
            this.Tests = new HashSet<Test>();
        }
    
        public int t_id { get; set; }
        [Required(ErrorMessage = "This Field is Required.")]
        [Display(Name = "User Name")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Max 50 characters, Minimum 3.")]
        public string username { get; set; }

        [Required(ErrorMessage = "This Field is Required.")]
        [Display(Name = "Name")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Max 50 characters, Minimum 3.")]
        public string name { get; set; }
        [Required(ErrorMessage = "This Field is Required.")]
        [Display(Name = "Password")]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Max 50 characters, Minimum 8.")]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [Required(ErrorMessage = "This Field is Required.")]
        [Display(Name = "Email")]
        public string email { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Test> Tests { get; set; }
    }
}