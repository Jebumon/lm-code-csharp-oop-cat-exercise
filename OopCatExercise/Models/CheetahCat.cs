using System;
using System.Collections.Generic;
using System.Text;

namespace OopCatExercise.Models
{
    public class CheetahCat : Cat
    {
        public CheetahCat() : base(averageheight: 0, setting: "wild")
        {
        }
        public override string Eat() => "Zzzzzzz";
    }
}
