using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace EntApDevFristProject.Pages
{
    public class TimeModel : PageModel
    {
        [BindProperty]
        public bool[] DaysChoice { get; set; } = new bool[7];
        public string[] DayOfWeek { get; set; } = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        [BindProperty]
        public string[] ChoiceMonths { get; set; } = { };
        public List<SelectListItem> Months { get; set; } = new List<SelectListItem>
        { new SelectListItem ("Sunday", "Sunday"),
          new SelectListItem ("Monday", "Monday"),
          new SelectListItem ("Tuesday", "Tuesday"),
          new SelectListItem ("Wednesday", "Wednesday"),
          new SelectListItem ("Thursday", "Thursday"),
          new SelectListItem ("Friday", "Friday"),
          new SelectListItem ("Satuday", "Saturday"),
        };

        //public List<SelectListItem> Months { get; set; } =
        //new List<SelectListItem>
        //{ new SelectListItem(){Text="Janeiro", Value="Janeiro"},
          //  new SelectListItem(){Text="2", Value="2"}
        //};

        public void OnGet()
        {

        }

        public void OnPost()
        {
            
        }


    }
}