using System.Collections;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField]
    private Vector3 _rotate;
    private Rigidbody _rigidbody;

    private IEnumerator Start()
    {
        _rigidbody = FindObjectOfType<Rigidbody>();
        while (true)
        {
            //_rigidbody.rotation = Quaternion.Euler(_rigidbody.rotation * _rotate);

            //var angle = transform.eulerAngles;
            //angle += _rotate * Time.deltaTime;
            yield break;
            //_rigidbody.RotateAround();
        }
    }

    void Update()
    {
        transform.Rotate(_rotate);
    }
}
