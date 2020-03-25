using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPToTheCentre : MonoBehaviour
{
    Vector2 ballDirection;
    Vector2 respawn = new Vector2(0,0);
    public GameObject ball;
    private void OnTriggerEnter2D(Collider2D other)
    {
        BallFisics controller = other.GetComponent<BallFisics>();
        // Debug.Log("Object that entered the trigger: " + other);
        if (controller != null)
        {
            Destroy(controller.gameObject);
            GameObject projectileObject = Instantiate(ball, respawn , Quaternion.identity);
            BallFisics ballFisics = ball.GetComponent<BallFisics>();
        }
    }
}
