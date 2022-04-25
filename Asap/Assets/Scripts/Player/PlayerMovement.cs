using UnityEngine;
 
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rb;
 
    [SerializeField] private float _movementSpeed;
    
    public Vector2 Velocity 
    {
        get { return _rb.velocity; }
        private set { _rb.velocity = value; } 
    }
 
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
 
    private void Update() 
    {
        Move();
    }
 
    private void Move()
    {
        float direction = Input.GetAxisRaw("Horizontal");
 
        Velocity = new Vector2(direction * _movementSpeed, Velocity.y);
    }
}