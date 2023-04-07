using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightBorder : MonoBehaviour
{
    public bool back;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Player.turnBack = back;
        }
    }
}
