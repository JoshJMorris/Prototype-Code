using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slideSpawner : MonoBehaviour
{
   
    public float uSpeed = 1f;
    public float dSpeed = 10f;
    private float maxLimit = 3/2f;
    private float minLimit = -3f;
    Vector2 slideVector;
    // Start is called before the first frame update
    void Start()
    {  
    }

    // Update is called once per frame
    /*I kept this in even though it's not functioning as an example of mistakes
     *I strongly believe I wrote this code poorly from the start and it's flawed
     *from the very ground up, I'll probably rework it as my own personal project later
     */
    void Update()
    {
        if (transform.position.y > maxLimit)
        {
            transform.Translate(Vector3.right * uSpeed * Time.deltaTime); // Will move the parent up overtime. 
        }
        else if (transform.position.y < minLimit)// || transform.position.y
        {
            transform.Translate(Vector3.left  * dSpeed * Time.deltaTime); // Will move the parent down overtime
        }
    }
}
