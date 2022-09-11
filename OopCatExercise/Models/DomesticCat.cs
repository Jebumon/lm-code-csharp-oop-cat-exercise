using System;
using System.Collections.Generic;
using System.Text;

namespace OopCatExercise.Models
{

    public class DomesticCat : Cat
    {
        public DomesticCat() : base(averageheight: 23, setting: "domestic")
        {
        }

        public override string Eat() => "Purrrrrrr";
        
    }
}
