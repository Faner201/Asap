using UnityEngine;

public class Monster : MonoBehaviour
{
    private Rigidbody2D rigid;
    private SpriteRenderer spriter;
    [SerializeField] private float speed;
    private Transform player;

    const float monsterDistation = 1f;

    public Vector2 Velocity
    {
        get { return rigid.velocity;}
        private set {rigid.velocity = value;}
    }

    private void Awake() 
    {
        rigid = GetComponent<Rigidbody2D>();
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
        if(Mathf.Abs(direction.x) < monsterDistation)
            return;
        rigid.velocity = direction.normalized * speed;
    }
    public void Death()
    {
        Destroy(gameObject);
    }

    private void Update() 
    {
        Move();
    }
}
