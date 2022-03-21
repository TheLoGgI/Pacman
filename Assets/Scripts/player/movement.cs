using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private Rigidbody2D rb;

    private int moveSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        float moveVertical = Input.GetAxis("Vertical");

        Debug.Log (moveVertical);

        if (
            Input.GetKey("a") ||
            Input.GetKey("left") ||
            Input.GetKey("d") ||
            Input.GetKey("right")
        )
        {
            Vector2 newSpeed = rb.velocity;
            newSpeed.x = moveSpeed * moveHorizontal;
            rb.velocity = newSpeed;
        }

        if (
            Input.GetKey("s") ||
            Input.GetKey("down") ||
            Input.GetKey("w") ||
            Input.GetKey("up")
        )
        {
            Vector2 newSpeed = rb.velocity;
            newSpeed.y = moveSpeed * moveVertical;
            rb.velocity = newSpeed;
        }

        //stop moving when needed too
        if (Mathf.Abs(moveHorizontal) >= 0 && Mathf.Abs(moveVertical) >= 0)
        {
            Debug.Log("stopeped");
            rb.velocity = Vector2.Lerp(rb.velocity, Vector2.zero, 0.5f);
        }
    }
}
