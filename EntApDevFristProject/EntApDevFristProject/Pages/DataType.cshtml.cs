using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntApDevFristProject.Pages
{
    public class DataTypeModel : PageModel
    {
        [BindProperty]
        [DataType(DataType.CreditCard)]
        public string CreditCard { get; set; }

        [BindProperty]
        [DataType(DataType.Currency)]
        public string Currency { get; set; }

        [BindProperty]
        [DataType(DataType.Duration)]
        public string Duration { get; set; }

        [BindProperty]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [BindProperty]
        [DataType(DataType.Html)]
        public string Html { get; set; }
        [BindProperty]
        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }
        [BindProperty]
        [DataType(DataType.MultilineText)]
        public string MlText { get; set; }
        [BindProperty]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [BindProperty]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }


        [BindProperty]
        [DataType(DataType.PostalCode)]
        public string PostalCode { get; set; }


        [BindProperty]
        [DataType(DataType.Url)]
        public string WebAddress { get; set; }

        [BindProperty]
        [DataType(DataType.Upload)]
        public string Upload { get; set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {

        }
    }
}

/*namespace EntApDevFristProject.Pages
{
    public enum DataType
    {

        Custom = 0,
        DateTime = 1,
        Date = 2,
        Time = 3,
        Duration = 4,
        PhoneNumber = 5,
        Currency = 6,
        Text = 7,
        Html = 8,
    }


    public class DataTypeModel : PageModel
    {
        public string gabriel { get; set; }


        public void OnGet()
        {

        }
    }
}*/
