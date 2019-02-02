using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntApDevFristProject.Pages
{
    public class taghelpplayModel : PageModel
    {
        public string Message { get; set; }
        [BindProperty]
        [Display(Name ="Number 1")]
        public int Number1 { get; set; }
        [BindProperty]
        [Display(Name = "Number 2")]
        public int? Number2 { get; set; }
        [BindProperty]
        [Display(Name = "Number 3")]
        public double Number3 { get; set; }
        [BindProperty]
        [Display(Name = "Number 4")]
        public double? Number4 { get; set; }
        [BindProperty]
        [Display(Name = "Number 5")]
        public decimal Number5 { get; set; }
        [BindProperty]
        [Display(Name = "Number 6")]
        public decimal? Number6 { get; set; }
        [BindProperty]
        [Display(Name = "Number 7")]
        public float Number7 { get; set; }
        [BindProperty]
        [Display(Name = "Number 8")]
        public float? Number8 { get; set; }
        [BindProperty]
        [Display(Name = "Text")]
        public string Text  { get; set; }
        [BindProperty]
        [Display(Name = "Time")]
        public DateTime DateTime { get; set; }
        [BindProperty]
        [Display(Name = "IsContactAllowed")]
        public bool IsContactAllowed { get; set; }
        [BindProperty]
        public string Season { get; set; }


        public void OnGet()
        {
            
        }

        public void OnPost()
        {
            
            Message = ($"The season chosen it was {Season}");
           
        }
    }
}