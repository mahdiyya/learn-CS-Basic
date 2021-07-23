using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunData : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerData hero = new PlayerData();
        int heroHealth = hero.GetHealth();
        Debug.Log("Health : " + heroHealth);
        int currentHealth = heroHealth - 10;
        hero.SetHealth(currentHealth);
        Debug.Log("Health : " + hero.GetHealth());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
