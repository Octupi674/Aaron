using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    Rigidbody rb;
    public float JumpForce = 5f;
    public float Xvalue = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        {if(Input.GetKeyDown("space"))
        {
            Debug.Log("Jumped");
            rb.AddForce(0,JumpForce,0 * JumpForce, ForceMode.Impulse);
        }
        }
        {if(Input.GetKey("d"))
        {
            Debug.Log("Moved Right");
            rb.AddForce(Xvalue,0,0 * Xvalue, ForceMode.Impulse);
        }
        }
        {if(Input.GetKey("a"))
        {
            Debug.Log("Moved Left");
            rb.AddForce(-Xvalue,0,0 * -Xvalue, ForceMode.Impulse);
        }
        }
    }
}
