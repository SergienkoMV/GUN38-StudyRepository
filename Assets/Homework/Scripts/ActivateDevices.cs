using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActivateDevices : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (!Mouse.current.enabled)
        {

            InputSystem.EnableDevice(Mouse.current);

        }

        if (!Keyboard.current.enabled)
        {

            InputSystem.EnableDevice(Keyboard.current);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
