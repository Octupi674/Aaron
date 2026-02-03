using UnityEngine;

public class FaceDirection : MonoBehaviour
{
    Rigidbody rb;
    Vector3 initialForward;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
 
        initialForward = transform.forward;
         
        
    }

    void Update()
    {
        Vector3 velocity = rb.linearVelocity;


        if (velocity.x > 0.05f)
        {

            transform.rotation = Quaternion.LookRotation(initialForward);
        }
        else if (velocity.x < -0.05f)
        {

            transform.rotation = Quaternion.LookRotation(-initialForward);
        }

        if (transform.rotation.z >= 100 && transform.rotation.z <= -100)
        {
            Debug.Log("flip");

            transform.localScale = new Vector3(1f, -1f, 1f);

        }


    }

}

