using UnityEngine;

public class Gates : MonoBehaviour
{
    private int _score = 0;
    
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
