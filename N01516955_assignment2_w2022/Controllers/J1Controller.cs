using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01516955_assignment2_w2022.Controllers
{
    public class J1Controller : ApiController
    {
        // Problem taken J1 - The New CCC (Canadian Calorie Counting)
        /// <summary>
        /// Input the index of Burger, Drinks, Sides and Desserts calories and it returns the total calories of the meal
        /// </summary>
        /// <param name="Burger">The index of burger choice </param>
        /// <param name="Drink">The index of drink choice </param>
        /// <param name="Side">The index of side choice </param>
        /// <param name="Dessert">The index of dessert </param>
        /// <returns>The total calories of the meal is</returns>
        /// example:
        //GET : http://localhost/api/J1/Menu/4/4/4/4  --> The total calories of the meal is:0
        //GET : http://localhost/api/J1/Menu/1/2/3/4  --> The total calories of the meal is:691



        [HttpGet]
        [Route("api/J1/Menu/{Burger}/{Drink}/{Side}/{Dessert}")]
        public string Menu(int Burger, int Drink, int Side, int Dessert)
        {
            
            int[] burger_c = { 461, 431, 420, 0 };
            int[] drink_c = { 130, 160, 118, 0 };
            int[] side_c = { 100, 57, 70, 0 };
            int[] dessert_c = { 167, 266, 75, 0 };

            
            int sum_of_calories = burger_c[Burger - 1] + drink_c[Drink - 1] + side_c[Side - 1] + dessert_c[Dessert - 1];

            string result = "The total calories of the meal is:" + " " + sum_of_calories;
            return result;
        }
    }
}


