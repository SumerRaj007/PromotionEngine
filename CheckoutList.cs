﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine
{
    class CheckoutList
    {
       

            public string Id { get; set; }
            public decimal Price { get; set; }


            public CheckoutList(string id)
            {
                this.Id = id;
                switch (id)
                {
                    case "A":
                        this.Price = 50m;

                        break;
                    case "B":
                        this.Price = 30m;

                        break;
                    case "C":
                        this.Price = 20m;

                        break;
                    case "D":
                        this.Price = 2015m;
                        break;
                }
            }
        }
    }