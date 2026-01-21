using UnityEngine;
using System.Collections;

public class delayer : MonoBehaviour
{
   
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            spinny();
           StartCoroutine(NoahNeedsToSYBAU());
        }
    }

    IEnumerator NoahNeedsToSYBAU() 
    {
        yield return new WaitForSecondsRealtime(2f);
        Destroy(gameObject);
    }
    
    void spinny()
    {
        transform.Rotate(0, 10, 0);
    }
}

