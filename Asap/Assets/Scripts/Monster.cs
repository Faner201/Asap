using UnityEngine;

public class Monster : MonoBehaviour
{
    private Rigidbody2D rigibody;
    private SpriteRenderer spriter;
    [SerializeField] private float speed;
    private Transform player;

    private void Awake() 
    {
        rigibody = GetComponent<Rigidbody2D>();
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
        rigibody.velocity = direction.normalized * speed; 
    }
    private void Animate()
    {
        spriter.flipX = rigibody.velocity.x < 0;
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
