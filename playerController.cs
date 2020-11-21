
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private string v = "Vertical";
    private string h = "Horizontal";
    private float vSpeed = 3f;
    private float HSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float moveY = Input.GetAxis(v);
        float moveX = Input.GetAxis(h);

        transform.Translate(Vector3.right * Time.deltaTime * vSpeed * moveX);
        transform.Translate(Vector3.up * Time.deltaTime * vSpeed * moveY);
    }
}
