using System;
using System.Collections.Generic;
using System.Text;

namespace OopCatExercise.Models
{
    public class LionCat : Cat
    {
        public LionCat() : base(averageheight: 1100, setting: "domestic")
        {
        }
        public override string Eat() => "Roar!!!!";
    }
}
