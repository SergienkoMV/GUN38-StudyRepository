using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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

    private IEnumerator Start()
    {
        var time = 0f;
        while (true)
        {
            
            if (_moveForvard)
            {
                transform.position = Vector3.Lerp(_start, _end, _speed * time / _moveTime);
            }
            else
            {
                transform.position = Vector3.Lerp(_end, _start, _speed * time / _moveTime);
            }
            
            time += Time.deltaTime;
            if (time > _moveTime)
            {
                time = 0f;
                _moveForvard = !_moveForvard;
                yield return new WaitForSeconds(_delay);
            }

            yield return null;
        }
    }
}
