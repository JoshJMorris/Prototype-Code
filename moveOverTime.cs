using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveOverTime : MonoBehaviour
{
    Vector3 FY;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(0, 0, 90);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime); // Will move the parent left overtime. 
        transform.Translate(FY); // Locks the Y axis in place, tried with RigidBody2D but freezing Y didn't work. Unsure why, this is a fine fix though.
      
    }
}
