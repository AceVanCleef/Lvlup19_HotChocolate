using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    [Range(1, 2)]
    public int PlayerNumber = 1;

    private string horizontalAxis;
    private string verticalAxis;
    private string aButton;
    private string bButton;
    private string triggerAxis;
    private int controllerNumber;

    //debugging.
    public float Horizontal;
    public float Vertical; // { get; set; }
    public bool APressed;
    public bool BPressed;

    public bool IsBot { get; set; }

    public bool OverrideA { get; set; }
    public bool OverrideB { get; set; }

    public enum Button
    {
        A,
        B
    }

    internal bool ButtonIsDown(Button button)
    {
        switch (button)
        {
            case Button.A:
                return IsBot ? OverrideA : Input.GetButton(aButton);
            case Button.B:
                return IsBot ? OverrideB : Input.GetButton(bButton);

        }
        return false;

    }

    internal void SetControllerNumber(int number)
    {
        controllerNumber = number;
        horizontalAxis = "J" + controllerNumber + "Horizontal";
        verticalAxis = "J" + controllerNumber + "Vertical";
        aButton = "J" + controllerNumber + "A";
        bButton = "J" + controllerNumber + "B";
        triggerAxis = "J" + controllerNumber + "Trigger";
    }

    // Start is called before the first frame update
    void Start()
    {
        SetControllerNumber(PlayerNumber);
        r = GetComponent<SpriteRenderer>();
    }

    Renderer r;

    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxis(horizontalAxis);
        Vertical = Input.GetAxis(verticalAxis);
        APressed = Input.GetButton(aButton);
        BPressed = Input.GetButton(bButton);
        foreach(string s in Input.GetJoystickNames()){
            Debug.Log(s);
        }
        Debug.Log(Input.GetJoystickNames().Length);
        Debug.Log("Player " + PlayerNumber + " : H? " + Horizontal + " V? " + Vertical + " A? " + APressed + " B? " + BPressed);

        Vector3 temp = transform.position;
        if(Horizontal > 0.01) temp.x += Horizontal;
        if (Vertical > 0.01) temp.y += Vertical;
        transform.position = temp;

        if (APressed) r.material.color = Color.green;
        if (BPressed) r.material.color = Color.red;
    }

    private void FixedUpdate()
    {
        /*
        Horizontal = Input.GetAxis(horizontalAxis);
        Vertical = Input.GetAxis(verticalAxis);
        APressed = Input.GetButton(aButton);
        BPressed = Input.GetButton(bButton);
        */
    }
}
