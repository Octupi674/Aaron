using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewMonoBehaviourScript : MonoBehaviour
{

    Vector3 startPosition;
    Rigidbody rb;
    public float JumpForce = 5f;
    public float Xvalue = 0.075f;
    bool isGrounded;
    public LayerMask groundLayer;
    public float maxSpeed;
    public float speed;
   

    public Transform groundCheckOrigin;
    float groundCheckDistance;

    
    statManager Statmanager;

    private void Awake()
    {
        startPosition = transform.position;
        Statmanager = FindObjectOfType<statManager>();
    }
    
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


    void OnCollisionEnter(Collision collision)
    {
         if (collision.gameObject.tag == "ground")
        {
            isGrounded = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "collectable")
        {
            Statmanager.ChangeCoins(1);
            Destroy(other.gameObject);
        }
        if(other.tag == "killPlayer")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    public void Die()
    {
        transform.position = startPosition;
    }

   
}           
