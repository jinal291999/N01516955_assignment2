using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01516955_assignment2_w2022.Controllers
{
    public class J3Controller : ApiController
    {   ///Taken problem from 2011 canadian computing competition  Sumac sequences
        ///Source link:https://cemc.math.uwaterloo.ca/contests/computing/2011/stage1/juniorEn.pdf
        /// <summary>
        /// Returns the length of the sumac sequence given by the starting numbers t1 and t2
        /// </summary>
        /// <param num1>The input number =120</param>
        /// <param num2>The input number=71</param>
        /// <returns>The length of the sumac sequence given by the starting numbers t1 and t2</returns>
        /// example
        ///Get : http://localhost:57326/api/J3/120/71

        [HttpGet]
            [Route("api/J3/{num1}/{num2}")]
            public int Get(int num1, int num2)
            {
                int count = 2;
                while (num2 < num1)
                {
                    int temp1 = num1;
                    num1 = num2;
                    num2 = temp1 - num2;
                    count = count + 1;
                }
                return count;
            }
        }
    }

