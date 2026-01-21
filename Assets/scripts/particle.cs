using UnityEngine;


public class particle : MonoBehaviour
{

    public ParticleSystem PP;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown("b"))
        {
            PP.Play();
        }
    }
}
