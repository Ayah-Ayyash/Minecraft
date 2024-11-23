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
                 health = Mathf.Clamp(value, 0, 100);
            }
        }




        public Character(string name, int Health, Position position)
        {
            this.name = name;
            this.Health = Health;
            this.position = position;
        }

        public Character() : this("", 100, new Position(0,0,0))
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

        public void Attack(int damage, Character target)
    {
        target.Health -= damage;
    }

   
    public void Attack(int damage, Character target, string attackType)
{
    target.Health -= damage;  
    Debug.Log($"Attack Type: {attackType}, Target: {target.name}, Damage: {damage}");
}

}}