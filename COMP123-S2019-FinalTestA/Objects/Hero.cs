using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Student Name: Mohammad S Hossain
 * Student ID: 300763479
 * Description: This is the Hero data container class
 */
namespace COMP123_S2019_FinalTestA.Objects
{
    class Hero
    {
        //Identity
        public string HeroName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        //Physical abilities
        public string Fighting { get; set; }
        public string Strength { get; set; }
        public string Agility { get; set; }
        public string Endurance { get; set; }

        //Mental abilities
        public string Reason { get; set; }
        public string Intuition { get; set; }
        public string Psyche { get; set; }
        public string Popularity { get; set; }

        //power list
        List<Power> Powers;

        //constructor
        Hero()
        {
            //instantiate an emplty power list
            Powers = new List<Power>();

        }

    }
}
