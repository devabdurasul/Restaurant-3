﻿using System;

namespace Restaurant
{
    public class Cook
    {
        public MenuItemInterface chicken = new Chicken();
        public MenuItemInterface egg = new Egg();

        public Cook()
        {
        }


        public void Process(TableRequests tableRequests)
        {
            var chickenOrders = tableRequests[chicken];
            for (int i = 0; i < chickenOrders.Length; i++)
            {
                if (chickenOrders[i] is null) continue;
                var chicken = chickenOrders[i] as Chicken;
                chicken.PrepareFood();
            } 

            var eggOrders = tableRequests[egg];
            for (int i = 0; i < eggOrders.Length; i++)
            {
                if (eggOrders[i] is null) continue;
                var egg = eggOrders[i] as Egg;
                egg.PrepareFood();
            }
        } 
    }
}
