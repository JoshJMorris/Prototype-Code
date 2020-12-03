using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.DrawRay(transform.position, Vector2.right * 6, Color.green); // Create visual ray for visual representation of where the ray would fire from. (Make sure the 'gizmos' is enabled in Unity editor to see this green ray)

        if (Input.GetKeyDown(KeyCode.Space) == true) // Space pressed 
        {
            print("Space pressed");
            RaycastHit2D ray = Physics2D.Raycast(transform.position, Vector2.right * 6); // create and send out ray if space pressed
            if (ray.collider != null && ray.collider.gameObject.layer == 8) // If ray detects the layer "Enemy" 
            {

                print(ray.collider.gameObject.name); // Print the name of the pickup it grabbed
                Destroy(ray.collider); // Destroy the pickup it collides with 

            }
        }
    }
}
