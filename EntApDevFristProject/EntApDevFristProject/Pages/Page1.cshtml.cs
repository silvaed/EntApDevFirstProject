using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntApDevFristProject.Pages
{
    public class Page1Model : PageModel

      
    {

        public string Message { get; set; }
        [BindProperty]
        public int Number { get; set; }

        public void OnGet()
        {
            Message = "Hello World From a Get Method";
        }

        //public void OnPost(int number)
        //{
        //    Number = number;
        //  Message = String.Format($"Hello from  the Post Method number was {Number}");
        //}

        public void OnPost(int number)
        {
            Number = number;
           Message = String.Format($"Hello from  the Post Method number was {Number}");
        }
    }
}