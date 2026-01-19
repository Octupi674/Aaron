using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    Rigidbody rb;
    public float JumpForce = 5f;
    public float Xvalue = 0.075f;
    bool isGrounded;
    public LayerMask groundLayer;
    public float maxSpeed;
    public float speed;
    public Transform groundCheckOrigin;
    float groundCheckDistance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log("six seven lol");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space") && isGrounded)
        {
            isGrounded = false;
            Debug.Log("Jumped");
            rb.AddForce(0,JumpForce,0, ForceMode.Impulse);
        }
        
        if(Input.GetKey("d"))
        {
            Debug.Log("Moved Right");
            rb.AddForce(Xvalue ,0,0, ForceMode.Impulse);
        }
        
        if(Input.GetKey("a"))
        {
            Debug.Log("Moved Left");
            rb.AddForce(-Xvalue ,0,0, ForceMode.Impulse);
        }
        
        if (rb.linearVelocity.x > -maxSpeed)
        {
            speed = 25;
        }
        else
        {
            speed = 5;
            Debug.Log ("lowering speed");
            rb.AddForce(Vector3.left * -1f, ForceMode.Impulse);
        }

        if (rb.linearVelocity.x < maxSpeed)
        {
            speed = 25;
        }
        else
        {
            speed = 5;
            Debug.Log ("lowering speed");
            rb.AddForce(Vector3.right * -1f, ForceMode.Impulse);
        }
    }


}           
