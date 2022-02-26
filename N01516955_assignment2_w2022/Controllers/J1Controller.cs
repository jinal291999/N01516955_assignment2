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
        //GET : /api/J1/Menu/{burger}/{drink}/{side}/{dessert}
        [HttpGet]
        [Route("api/J1/Menu/{Burger}")]
        public int Menu(int Burger int Drink int Side int Dessert)
        {
            if (Burger == 1)
            {
                return 461;
            }
            else if (Burger == 2)
            {
                return 431;
            }
            else if (Burger == 3)
            {
                return 420;
            }
            else
            {
                return 0;
            

            if (Side == 1)
            {
                return 130;
            }
            else if (Side == 2)
            {
                return 160;
            }
            else if (Side == 3)
            {
                return 118;
            }
            else
            {
                return 0;
            }
        }
    }
          //  [Route("api/J1/Menu/{Burger}")]
          //  public int Burger(int Burger)
           // {
              
          //  }

            [Route("")]
            public int Side(int Side)
            {
                // side
                

            [Route("Drink")]
            public int Drink(int Drink)
            {
                if (Drink == 1)
                {
                    return 130;
                }
                else if (Drink == 2)
                {
                    return 160;
                }
                else if (Drink == 3)
                {
                    return 118;
                }
                else
                {
                    return 0;
                }
            }

            [Route("Dessert")]
            public int Dessert(int Dessert)
            {

                // dessert
                if (Dessert == 1)
                {
                    return 130;
                }
                else if (Dessert == 2)
                {
                    return 160;
                }
                else if (Dessert == 3)
                {
                    return 118;
                }
                else
                {
                    return 0;
                }
            }

        }
    }
