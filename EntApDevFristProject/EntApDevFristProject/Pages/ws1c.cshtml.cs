using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntApDevFristProject.Pages
{
    public class ws1cModel : PageModel
    {
        public string Result;

        public void OnGet()
        {

        }

        public void OnPost(int number1, int number2 , int op)
        {
            int number;
            if (op == 1)
            {
                number = number1 + number2;
                Result = string.Format($"{number1} + {number2} = {number}");
            }

            if (op == 2)
            {
                number = number1 - number2;
                Result = string.Format($"{number1} - {number2} = {number}");
            }

            if (op == 3)
            {
                number = number1 * number2;
                Result = string.Format($"{number1} * {number2} = {number}");
            }

            if (op == 4)
            {
                number = number1 / number2;
                Result = string.Format($"{number1} / {number2} = {number}");
            }
        }
    }
}