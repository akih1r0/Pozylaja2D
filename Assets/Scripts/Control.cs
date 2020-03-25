using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    Vector2 ballDirection;
    Vector2 respawn = new Vector2(0, 0);
    public GameObject ball;
    public GameObject player1;
    public GameObject player2;
    private KeyCode upBut1 = KeyCode.W;
    private KeyCode upBut2 = KeyCode.UpArrow;
    private KeyCode downBut1 = KeyCode.S;
    private KeyCode downBut2 = KeyCode.DownArrow;
    private Rigidbody2D pl1;
    private Rigidbody2D pl2;
    public float speed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        FirstBall();
        pl1 = player1.GetComponent<Rigidbody2D>();
        pl2 = player2.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(upBut1))
        {
            pl1.MovePosition(pl1.position + Vector2.up * speed * Time.deltaTime);
        }
        if (Input.GetKey(downBut1))
        {
            pl1.MovePosition(pl1.position + Vector2.down * speed * Time.deltaTime);
        }
        if (Input.GetKey(upBut2))
        {
            pl2.MovePosition(pl2.position + Vector2.up * speed * Time.deltaTime);
        }
        if (Input.GetKey(downBut2))
        {
            pl2.MovePosition(pl2.position + Vector2.down * speed * Time.deltaTime);
        }
    }


    void FirstBall()
    {
        GameObject projectileObject = Instantiate(ball, respawn, Quaternion.identity);
        BallFisics ballFisics = ball.GetComponent<BallFisics>();
    }
}
