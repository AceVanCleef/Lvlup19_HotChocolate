using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Range(1, 2)]
    public float PlayerNumber;

    public KeyCode VerticalUp;
    public KeyCode VerticalDown;
    public KeyCode HorizontalLeft;
    public KeyCode HorizontalRight;
    public KeyCode Action1;
    public KeyCode Action2;

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<SpriteRenderer>();
        rb.GetComponent<Rigidbody2D>();
    }

    SpriteRenderer r;

    // Update is called once per frame
    void Update()
    {
        Vector3 movement;

        if (Input.GetKeyDown(VerticalUp))
        {

        }
        if (Input.GetKeyDown(VerticalDown))
        {

        }
        if (Input.GetKeyDown(HorizontalLeft))
        {

        }
        if (Input.GetKeyDown(HorizontalRight))
        {

        }
        if (Input.GetKeyDown(Action1))
        {
            r.material.color = Color.red;
        }
        if (Input.GetKeyDown(Action1))
        {
            r.material.color = Color.green;
        }

        //from Mary project
        //_player.SetFloat("X", Input.GetAxis("Horizontal"));))
    }
}
