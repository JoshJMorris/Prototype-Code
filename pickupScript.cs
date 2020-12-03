using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupScript : MonoBehaviour
{
    public float Pickups = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.layer == 9)
        {
            Destroy(col.gameObject);
            Pickups = Pickups + 1;
            print("PICKUPS: " + Pickups); // Didn't add UI, check Console to see the amount of pickups in the current gameplay session.

        }

    }
}

