using System.Collections;
using UnityEngine;

public class NewMover : MonoBehaviour
{
    [SerializeField]
    private Vector3 _start, _end;

    [SerializeField]
    private float _speed;

    [SerializeField]
    private float _delay;

    [SerializeField]
    private float _moveTime;

    private bool _moveForvard = true;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private IEnumerator Start()
    {
        var time = 0f;
        while (true)
        {
            
            if (_moveForvard)
            {
                _rigidbody.MovePosition(Vector3.Lerp(_start, _end, /*_speed **/ time / _moveTime));
            }
            else
            {
                _rigidbody.MovePosition(Vector3.Lerp(_end, _start, /*_speed **/ time / _moveTime));
            }
            
            time += Time.deltaTime;
            if (time > _moveTime)
            {
                time = 0f;
                _moveForvard = !_moveForvard;
                yield return new WaitForSeconds(_delay);
            }

            yield return new WaitForFixedUpdate();
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(_start, _end);
    }
}
