using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01516955_assignment2_w2022.Controllers
{
    public class J2Controller : ApiController
    {
        //Problem taken J2 - Roll the Dice


        /// <summary>
        /// Return the total number ways to get the sum 10 with two dice
        /// </summary>
        /// <param name="m">The number of side on the first dice = 6</param>
        /// <param name="n">The number of side on the second dice = 8</param>
        /// <returns>There are 5 ways to get the sum 10</returns>
        /// example
        /// GET: http://localhost/api/J2/DiceGame/6/8
        /// GET: http://localhost/api/J2/DiceGame/12/4
        /// GET: http://localhost/api/J2/DiceGame/3/3
        /// GET: http://localhost/api/J2/DiceGame/5/5

        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string DiceGame(int m, int n)
        {
            //defined number of ways as 0
            int num = 0;

            for (int i = 1; i <= m; i++)     //m is the number of sides on the first die
                                             //n is the number of sides on the second die
            {
                for (int j = 1; j <= n; j++)
                {
                     
                    int sum = i + j;  // total number of sides on first dice and second dice

                    if (sum == 10)       //checking if sum is equal to 10
                    {
                        num++;
                    }
                }
            }
            string finalOutput = "There are "+ num +" ways to get the sum 10.";
            return finalOutput;
        }
    }
}


    
  

