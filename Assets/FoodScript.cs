using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodScript : MonoBehaviour
{

    private int foodValue = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            foodCount.instance.ChangeFood(foodValue);
        }
    }

    void Update()
    {
        transform.Rotate(0, 0.5f, 0);
    }
}
