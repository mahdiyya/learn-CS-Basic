using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    int health, power;
    string name;
    //  Constructor
    public Player(int health, int power, string name) {
        this.health = health;
        this.power = power;
        this.name = name;
    }
    public void Info(){
        Debug.Log("Player Created! Name : " + name +
        ", Power : " + power + ", Health : " + health);
    }
    public void Hello(){
        Debug.Log("Hello");
    }
}
