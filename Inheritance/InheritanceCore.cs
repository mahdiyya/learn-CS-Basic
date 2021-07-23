using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InheritanceCore : MonoBehaviour
{
   void Start() {
       PlayerInheritance killer = new PlayerInheritance();
       Hero hero = new Hero();
       killer.Info();
       hero.Info();
       killer.Hello();
       hero.Hello();
   }

   void Update() {
       
   }
}
