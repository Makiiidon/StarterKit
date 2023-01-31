using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public static InputHandler Instance;

    private Vector2 moveInput;

    [SerializeField] private KeyCode button1;
    [SerializeField] private KeyCode button2;
    [SerializeField] private KeyCode button3;
    [SerializeField] private KeyCode button4;

    private bool isButton1Pressed;
    private bool isButton2Pressed;
    private bool isButton3Pressed;
    private bool isButton4Pressed;
    // Start is called before the first frame update
    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }

        isButton1Pressed = false;
        isButton2Pressed = false;
        isButton3Pressed = false;
        isButton4Pressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(button1))
        {
            isButton1Pressed = true;
        }
        else if (!Input.GetKeyDown(button1))
        {
            isButton1Pressed = false;
        }

        if (Input.GetKeyDown(button2))
        {
            isButton2Pressed = true;
        }
        else if (!Input.GetKeyDown(button2))
        {
            isButton2Pressed = false;
        }
        
        if (Input.GetKeyDown(button3))
        {
            isButton3Pressed = true;
        }
        else if (!Input.GetKeyDown(button3))
        {
            isButton3Pressed = false;
        }
        
        if (Input.GetKeyDown(button4))
        {
            isButton4Pressed = true;
        }
        else if (!Input.GetKeyDown(button4))
        {
            isButton4Pressed = false;
        }

    }

    public Vector2 GetMove() { return moveInput; }
    public bool GetButton1() { return isButton1Pressed; }
    public bool GetButton2() { return isButton2Pressed; }
    public bool GetButton3() { return isButton3Pressed; }
    public bool GetButton4() { return isButton4Pressed; }

    public KeyCode ReturnButton1() { return button1; }
}
