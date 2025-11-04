using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Gates : MonoBehaviour
{
    private int _score = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Score: " + _score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<Ball>(out var ball))
        {
            Destroy(ball);
            _score += 1;
            Debug.Log("Score: " + _score);
        }
    }
}
