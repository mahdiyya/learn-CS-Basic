using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutines : MonoBehaviour
{
    // Start is called before the first frame update
    private IEnumerator coroutine;
    void Start()
    {
        NormalFunction(10);
        Debug.Log("Start Time : " + Time.time);
        // StartCoroutine(NewCoroutine());
        coroutine = NewCoroutine(5.0f);
        StartCoroutine(coroutine);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator NewCoroutine (float waitTime){
        yield return new WaitForSeconds(waitTime); // yield return new WaitForSeconds(seconds float)
        Debug.Log("Waited for " + waitTime + " Seconds, The Acccurate time is " + Time.time);
    
        // yield return new WaitForSeconds(2.0f);
        // Debug.Log("Waited for 5 Seconds , The Acccurate time is " + Time.time);
    }

    void NormalFunction(int a){
        Debug.Log("HAI" + a);
    }
}
