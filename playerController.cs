using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private string v = "Vertical";
    private float vSpeed = 1f;
    private float HSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveY = Input.GetAxis("Vertical");
        float moveX = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * Time.deltaTime * vSpeed * moveX);
        transform.Translate(Vector3.up * Time.deltaTime * vSpeed * moveY);
    }
}
