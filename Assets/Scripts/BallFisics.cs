using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallFisics : MonoBehaviour
{
    Rigidbody2D ballBody;
    private Vector2 ballDirection;
    byte rand;
    
    // Start is called before the first frame update
    void Awake()
    {
        ballBody = GetComponent<Rigidbody2D>();
        ballBody.constraints = RigidbodyConstraints2D.FreezeRotation;
        rand =(byte)Random.Range(-1, 1);
        if (rand<0)
        {
            ballDirection = new Vector2(rand, 0);
        }
        else 
        {
            ballDirection = new Vector2(1, 0);
        }

        ballBody.AddForce(ballDirection * 500);
        
    }

    // Update is called once per frame
    void Update()
    {
      //  ballBody.position += ballDirection;
    }

   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        

        if(collision.gameObject.tag == "Player")
        {
           
            
            ballDirection.x = -ballDirection.x;
            ballBody.AddForce(ballDirection * 500);
        }
        else
        {
         
            ballDirection.y = -ballDirection.y;
            ballBody.AddForce(ballDirection * 500);
        }

    }
}
