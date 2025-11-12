using System.Collections;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField]
    private Vector3 _rotate;
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private IEnumerator Start()
    {
        
        while (true)
        {
            Vector3 rotation = _rotate * Time.fixedDeltaTime;
            Quaternion rotationQuaternion = Quaternion.Euler(rotation);
            _rigidbody.MoveRotation(_rigidbody.rotation * rotationQuaternion);
            yield return new WaitForFixedUpdate();
        }
    }

    void Update()
    {
        //transform.Rotate(_rotate);
    }
}
