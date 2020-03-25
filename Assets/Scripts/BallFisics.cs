using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallFisics : MonoBehaviour
{
    private byte BallVector;
    Rigidbody2D rbBall;
    public float speed = 20f;
    private ConstantForce2D suka;
    
    // Start is called before the first frame update
    void Start()
    {
        
        suka = GetComponent<ConstantForce2D>();

        rbBall = GetComponent<Rigidbody2D>();
        BallVector = (byte) Random.Range(0, 1);
        if(BallVector == 1)
        {
            suka.force = new Vector2(9.8F, 0);
        }

        else
        {
            suka.force = new Vector2(-9.8F, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (BallVector == 1)
        {

            BallVector = 0;
            suka.force = new Vector2(-9.8F, 0);
        }
        else
        {
            suka.force = new Vector2(9.8F, 0);
            BallVector = 1;
        }
    }
}
