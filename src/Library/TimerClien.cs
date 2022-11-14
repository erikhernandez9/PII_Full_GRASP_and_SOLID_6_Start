using System;
using System.Threading;

namespace Full_GRASP_And_SOLID;

    public class TimerClien : TimerClient
    {
        public TimerClien(Recipe recip)
        {
            this.recipe = recip;
        }
        public Recipe recipe {get;set;}
        public void TimeOut()
        {
            this.recipe.Cooked = true;
        }
    }