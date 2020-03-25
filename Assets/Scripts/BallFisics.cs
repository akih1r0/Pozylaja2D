using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallFisics : MonoBehaviour
{
    Rigidbody2D ballBody;
    private Vector2 ballDirection;
    
    
    // Start is called before the first frame update
    void Awake()
    {
        ballBody = GetComponent<Rigidbody2D>();
        ballBody.constraints = RigidbodyConstraints2D.FreezeRotation;
        ballDirection = new Vector2(Random.Range(-1, 1), Random.Range(-1, 1));
        ballDirection.Normalize();
        
    }

    // Update is called once per frame
    void Update()
    {
        ballBody.position += ballDirection;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        

        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("Бодя Пидарас");
            ballDirection.x = -ballDirection.x;
        }
        else
        {
            Debug.Log("Бодя Лох");
            ballDirection.y = -ballDirection.y;
        }

    }
}
