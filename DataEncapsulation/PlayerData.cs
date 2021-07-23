using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData
{
    private int health, power; 
    private string name;

    public PlayerData(){
        health = 100;
        name = "Hero";
        power = 50;
    }

    public void Info(){
        Debug.Log("Player Created! Name : " + name +
        ", Power : " + power + ", Health : " + health);
    }

    public void SetHealth(int health){
        this.health = health;
    }
    public int GetHealth(){
        return this.health;
    }
}
