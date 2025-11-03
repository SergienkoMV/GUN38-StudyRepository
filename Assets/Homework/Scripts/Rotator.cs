using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Rotator : MonoBehaviour
{
    [SerializeField]
    private Vector3 _rotate;
    private Rigidbody _rigidbody;

    // Start is called before the first frame update
    private IEnumerator Start()
    {
        _rigidbody = FindObjectOfType<Rigidbody>();
        while (true)
        {
            _rigidbody.rotation = Quaternion.Euler(_rigidbody.rotation * _rotate);
            yield break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
