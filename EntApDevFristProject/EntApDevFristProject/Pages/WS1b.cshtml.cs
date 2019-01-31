using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntApDevFristProject.Pages
{
    public class WS1bModel : PageModel
    {
        public string Message { get; set; }

        public string Message2 { get; set; }

        public void OnGet()
        {

        }

        public void OnPost(int number1 , int number2 , string op)
        {
            int sum = number1 + number2;
            Message = string.Format($"The sum of {number1} and {number2} is {sum} ");

            
        }


        
    }
}