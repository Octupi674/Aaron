using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    Rigidbody rb;
    public float JumpForce = 5f;
    public float Xvalue = 0.075f;
    bool isGrounded;
    public float maxSpeed = 0.075f;
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
            rb.AddForce(0,JumpForce,0 * JumpForce, ForceMode.Impulse);
        }
        
        if(Input.GetKey("d") && maxSpeed> Vector3.Magnitude)
        {
            Debug.Log("Moved Right");
            rb.AddForce(Xvalue * Time.deltaTime,0,0, ForceMode.Impulse);
        }
        
        if(Input.GetKey("a") && maxSpeed> rb.Vector3.Left)
        {
            Debug.Log("Moved Left");
            rb.AddForce(-Xvalue * Time.deltaTime,0,0, ForceMode.Impulse);
        }
        
        
    }

    void OnCollisionStay(Collision other)
    {
        isGrounded = true;
    }
    
}           
