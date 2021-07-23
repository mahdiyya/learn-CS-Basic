using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : PlayerInheritance
{
   // Constactor
    public Hero(){
        health = 100;
        power = 100;
        name = "Hero";
    }
    public override void Hello(){
        Debug.Log("Haiii");
    }
}
