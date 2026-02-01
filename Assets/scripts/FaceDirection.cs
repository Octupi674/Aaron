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

            transform.rotation = Quaternion.LookRotation(initialForward, Vector3.up);
        }
        else if (velocity.x < -0.05f)
        {

            transform.rotation = Quaternion.LookRotation(-initialForward, Vector3.up);
        }
    }
}

