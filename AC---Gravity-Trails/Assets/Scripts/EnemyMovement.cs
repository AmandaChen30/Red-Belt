using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float yForce;
    public float xForce;
    public GameObject Portal;    

    private Rigidbody2D enemyRigidbody;
   
    // Start is called before the first frame update
    void Start()
    {
        enemyRigidbody = GetComponent<Rigidbody2D>();
        

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Vector2 jumpForce = new Vector2(xForce, yForce);
            enemyRigidbody.AddForce(jumpForce);
        }

        if(collision.gameObject.tag == "ThrowingObject")
        {
            Destroy(gameObject);
            Portal.GetComponent<Teleport>().EnemyCount--;
        }
    }

}
