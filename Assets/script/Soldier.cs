using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18
{
    public class Soldier : Character
    {

        public Soldier(string name, int Health, Position position) : base(name, Health, position)
        {

        }


        public override void DisplayInfo()
        {
            Debug.Log("Soldier");
            base.DisplayInfo();
        }
    }
}
