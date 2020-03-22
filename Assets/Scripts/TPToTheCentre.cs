using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPToTheCentre : MonoBehaviour
{
    public GameObject respawn;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Ball")
        {
            collision.transform.position = respawn.transform.position;
        }
    }
}
