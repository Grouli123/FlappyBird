using UnityEngine;

public class BirdFly : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private float velocity = 1f;
    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            _rb.velocity = Vector2.up * velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
    }
}
