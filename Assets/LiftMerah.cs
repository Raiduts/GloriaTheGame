using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftMerah : MonoBehaviour
{
    public static bool active;
    Rigidbody2D lift;
    // Start is called before the first frame update
    void Start()
    {
        lift = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(active){
            lift.velocity = new Vector2(0 , 5);  
        }
        else
        {
            lift.velocity = new Vector2(0 , -1); 
        }
    }
}
