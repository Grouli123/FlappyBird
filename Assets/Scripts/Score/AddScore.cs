using UnityEngine;
using Scriptable;

public class AddScore : MonoBehaviour
{
    [SerializeField] private IntegerVariable _scoreCounter;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _scoreCounter.ApplyChange(1);
    }
}
