using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private string v = "Vertical";
    // private string h = "Horizontal"; Correlates to Horizontal Movement
    private float vSpeed = 2f;
    private float maxLimit = 1f;
    private float minLimit = -2f;
    // private float HSpeed = 2f; Correlates to horizontal movement again
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float moveY = Input.GetAxis(v);
        // float moveX = Input.GetAxis(h); Gets the input for horizontal movement, might use later.

        //  transform.Translate(Vector3.right * Time.deltaTime * HSpeed * moveX); Might use later, don't know. Archived for now as I didn't make the ray shoot with the camera. 
        transform.Translate(Vector3.up * Time.deltaTime * vSpeed * moveY);
    }
    /* Was working on, might expand on in my free time over the holidays.
     * void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.layer == 10)
        {
            print(col.gameObject);
            gameObject.transform.Translate(col.gameObject.transform);
     */


}
   




