using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunGame : MonoBehaviour
{
    Animator anim;
    Rigidbody theRigidBody;
    Vector3 playerPosition;
    // Start is called before the first frame update
    void Start()
    {
        // Object -> ClassName objectName = new ConstractorName(value);
        Player hero = new Player(100, 20, "Hero"); 
        Player killer = new Player(50, 30, "Killer");
        Player warrior = new Player(80, 0, "Warrior");

        hero.Info(); // Calling Function Info with parameter of object hero
        killer.Info(); // Calling Function Info  with parameter of object killer
        warrior.Info(); // Calling Function Info  with parameter of object warrior
        hero.Hello(); // Calling Function Hello with parameter of object hero
        
        anim = GetComponent<Animator> (); // namaVariable = GetComponent<namaComponent>();
        theRigidBody = GetComponent<Rigidbody> ();
        playerPosition = transform.position;
        Debug.Log("Player Position : " + playerPosition);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Player Position : " + transform.position);
    }
}
