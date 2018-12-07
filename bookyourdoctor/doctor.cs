//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Linq;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
namespace bookyourdoctor
{
    
    public partial class doctor
    {
        public FINALSCRIPTTEntities db = new FINALSCRIPTTEntities();
        [Required]
        [Display(Name = "Doctor Id")]
        [RegularExpression(@"^([0-9]{7})*$",
            ErrorMessage = "Id length must be 7 and without dashes")]
        public string doctor_id { get; set; }

        [Required]
        [Display(Name = "Name")]
        
        public string name { get; set; }

        [Required]
        [Display(Name = "Date of birth")]
        public string date_of_birth { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string adress { get; set; }

        [Required]
        [Display(Name = "Phone")]
        [RegularExpression(@"^([0-9]{11})*$",
           ErrorMessage = "number length must be 13 and without dashes")]
        public string phone { get; set; }


        [Required]
        [Display(Name = "MBBS Code")]
        public int MBBS_Code { get; set; }

        [Required]
        [Display(Name = "Email")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string email { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 6,
            ErrorMessage = "passwords must be a minimum of 6 characters")]
        [Required(ErrorMessage = "Password is Required")]
        public string password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [System.ComponentModel.DataAnnotations.Compare("password")]
        [Required(ErrorMessage = "Confirm Password is Required")]
        public string confirm_password { get; set; }

        [Required]
        [Display(Name = "Clinic Name")]
        public string clinic_name { get; set; }

        [Required]
        [Display(Name = "Hospital Address")]
        public string hospital_address { get; set; }

        [Required]
        [Display(Name = "Hospital Name")]
        public string hospital_name { get; set; }

        [Required]
        [Display(Name = "Clinic Address")]
        public string clinic_address { get; set; }

        [Required]
        [Display(Name = "City")]
        public string city { get; set; }

        [Required]
        [Display(Name = "Specialization")]
        public string specialization { get; set; }

        [Required]
        [Display(Name = "Practising Years")]
        public int practising_years { get; set; }

        public static IEnumerable<SelectListItem> GetSpec()
        {
            IList<SelectListItem> items = new List<SelectListItem>
        {

            new SelectListItem { Text="Dentist",Value="Dentist"},
            new SelectListItem { Text="Cardiologist",Value="Cardiologist"},
            new SelectListItem { Text="Child Specialist",Value="Child Specialist"},
            new SelectListItem { Text="Gynecologist",Value="Gynecologist"},
            new SelectListItem { Text="Psychologist",Value="Psychologist"},
            new SelectListItem { Text="Dermatologist",Value="Dermatologist"},



        };
            return items;


        }

        public IEnumerable<doctor> doctorsspec(string spec)
        {
            var ide = db.doctors.Where(p => (p.specialization == spec));
            return ide;
        }
    }
}
