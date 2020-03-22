using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallFisics : MonoBehaviour
{
    private byte BallVector;
    private Rigidbody2D BallBody;
    public float speed = 20f;
    private Vector2 suka;
    // Start is called before the first frame update
    void Start()
    {
        BallBody = GetComponent<Rigidbody2D>();
        BallVector = (byte) Random.Range(0, 1);
        if(BallVector == 1)
        {
            suka = Vector2.right;
        }

        else
        {
            suka = Vector2.left;
        }
    }

    // Update is called once per frame
    void Update()
    {
        BallBody.MovePosition(BallBody.position + suka * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (suka == Vector2.right)
            suka = Vector2.left;
        else
            suka = Vector2.right;
    }
}
