using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;
namespace assignment16{
public class Charecter 
{
    public string name;
    private int _health;
    protected Position position;

    public int Health
    {
        get{return _health;}
        set
        {
            if (value < 0 ) _health = 0;
            else if (value > 100) _health = 100;
            else _health = value;
        }
    } 


    //parameterized constructor
    public Charecter(string name , int health ,Position position )
    {
        this.name = name;
        _health = health;
        this.position = position;
    }
    // default constructor
    public Charecter () : this ("No name", 100, new Position(0,0,0)){}

    public virtual void DisplayInfo()
    {
        Debug.Log("Name : "+ name);
        Debug.Log("Health : "+_health);
        position.PrintPosition();
    }

    public void Attack(int damage , Charecter target)
    {
        target.Health -= damage;
    }
     public void Attack(int damage , Charecter target,string attackType)
    {
        Attack(damage,target);
        Debug.Log(attackType);
    }

}
}
