using UnityEngine;

public class Monster : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    private SpriteRenderer spriter;
    [SerializeField] private float speed;
    private Transform player;

    private void Awake() 
    {
        rigidbody = GetComponent<Rigidbody2D>();
        spriter = GetComponentInChildren<SpriteRenderer>();
    }

    private void Start() 
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    private void Move()
    {
        Vector3 direction = player.position - transform.position;
        direction.y = 0;
        direction.z = 0;
        rigidbody.velocity = direction.normalized * speed; 
    }
    private void Animate()
    {
        spriter.flipX = rigidbody.velocity.x < 0;
    }
    public void Death()
    {
        Destroy(gameObject);
    }

    private void Update() 
    {
        Move();
        Animate();
    }
}
