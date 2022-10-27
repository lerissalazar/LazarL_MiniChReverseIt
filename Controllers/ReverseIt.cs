//lerissa lazar
//10-27-22
//reverse it
//the user will input numbers or letters and the computer will reverse it
//peer review : John Magpantay                           notes : Data validation for both int and string! good job! very well written codes, they are clean. Codes look simple but its doing whats its suppose to do. Good job 

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LazarL_MiniChReverseIt.Controllers
{
    [Route("[controller]")]
    public class ReverseIt : Controller
    {
        [HttpGet]
        [Route("Reverse/{input}")]
        public string Reverse(string input)
        {
            char[] reverseArray = input.ToCharArray();
            Array.Reverse(reverseArray);
            string revString = new string(reverseArray);
            
            return revString;
        }
    }
}