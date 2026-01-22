using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour
{

    private Transform target;
    private Transform enemyPosition;
    public float speed;
    private float direction;

    void start()

    {

        target = GameObject.FindGameObjectWithTag("Player").transform;
        enemyPosition = GameObject.FindGameObjectWithTag("killPlayer").transform;

    }

    void FixedUpdate()
    {

        float moveHorizontal = direction;

        Vector3 movement = new Vector3(moveHorizontal, 0.0f);
        GetComponent<Rigidbody2D>().linearVelocity = movement * speed;

        if (target.position.x > enemyPosition.position.x)
        {

            direction = 6;

        }

        if (target.position.x < enemyPosition.position.x)
        {

            direction = -6;

        }
    }

}