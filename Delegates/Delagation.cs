using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delagation : MonoBehaviour
{
    bool isDead;
    public delegate void LifeStatus();
    public static event LifeStatus notif;
    // Start is called before the first frame update
    void Start()
    {
        isDead = true;
        if (isDead == true){
            notif();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
