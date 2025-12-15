using UnityEngine;
using UnityEngine.InputSystem;

public class DeviceStarter : MonoBehaviour
{
    void Start()
    {
        if (!Mouse.current.enabled)
        {
            InputSystem.EnableDevice(Mouse.current);
        }
    }
}
