using System.Collections;
using System.Collections.Generic;
using Assignment18;
using UnityEngine;
namespace Assignment18
{
    public class Character
    {

        public string name;
        private int health;
        protected Position position;
        public int Health
        {
            get { return health; }
            set
            {
                if (value < 0)
                {
                    health = 0;
                }
                else if (value > 100)
                {
                    health = 100;
                }
                else
                {
                    health = value;
                }
            }
        }




        public Character(string name, int Health, Position position)
        {
            this.name = name;
            this.Health = Health;
            this.position = position;
        }

        public Character() : this("", 100, new Position(2, 8, 5))
        {

        }


        public virtual void DisplayInfo()
        {
            Debug.Log($"Name : {name}");
            Debug.Log($"Health : {Health}");
            position.PrintPosition();
        }

        // public void printPosition(int x , int y , int z){

        // }

        public void Attack(int damage, Character target, string attackType) // بده يقلل الهيلث 
        {
            Debug.Log($"Attack Type : {attackType}");
        }

        //DRY
        public void Attack(int damage, Character target)
        {
            //this.Health -= damage;
            target.Health -= damage;

        }
    }
}