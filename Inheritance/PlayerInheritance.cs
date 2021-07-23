using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInheritance
{
    protected int health, power; 
    protected string name;
    //  Constructor
    public PlayerInheritance() {
        health = 10;
        name = "Killer";
        power = 100;
    }
    public void Info(){
        Debug.Log("Player Created! Name : " + name +
        ", Power : " + power + ", Health : " + health);
    }
    public virtual void Hello(){ //agar bisa dioverride di child class
        Debug.Log("Hello");
    }
}
