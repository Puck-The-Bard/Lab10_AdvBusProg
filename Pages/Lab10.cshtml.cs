using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab10_AdvBusProg.Pages
{
    public class Lab10Model : PageModel
    {

        [BindProperty]
        [Display(Name = "First Name")]
        [Required]
        [StringLength(15)]
        public string FirstName {get; set;}

        [BindProperty]
        [Display(Name = "Last Name")]
        [Required]
        [StringLength(15)]
        public string LastName {get; set;}

        private readonly ILogger _log;
        public Lab10Model(ILogger<Lab10Model> log)
        {
            _log = log;
        }

        public void OnPost()
        {         
            _log.LogInformation("First Name = " + FirstName);

        
            _log.LogInformation("Last Name = " + LastName);
        }
    }
}
