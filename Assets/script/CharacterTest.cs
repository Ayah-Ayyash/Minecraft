using System.Collections;
using System.Collections.Generic;
using Assignment18;
using UnityEngine;
namespace Assignment18
{
    public class CharacterTest : MonoBehaviour
    {
        //اعمل نسخة ثم خزنها في مصفوفة


        void Start()
        {
            Soldier Sold = new Soldier("Ayah", 100, new Position(1, 3, 2));
            Soldier Off = new Soldier("Mohammed", 70, new Position(5, 4, 7));

            Character[] Child = new Character[2];
            Child[0] = Sold;
            Child[1] = Off;



            //  foreach (Character character in Child)
            //     {
            //         character.DisplayInfo();
            //     }



            for (int i = 0; i < Child.Length; i++)
            {
                Child[i].DisplayInfo();
            }


            //الآن بدي اطبع قيم سوليدير قبل وبعد الهجوم
            // بالتالي لازم يكون في هجوم
            Debug.Log($"Soldier Before Attack =  {Sold.Health}");


            int damage = 40;
            Off.Attack(damage , Sold);

             Debug.Log($"Soldier After Attack =  {Sold.Health}");

        }

    }
}