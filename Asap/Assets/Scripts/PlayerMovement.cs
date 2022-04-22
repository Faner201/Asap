using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rigibody;
    private SpriteRenderer spriteR;

    [SerializeField] private float speed;
    [SerializeField] private float jump;

    private void Awake()
    {
        rigibody = GetComponent<Rigidbody2D>();
        spriteR = GetComponentInChildren<SpriteRenderer>();
    }


    private void Run()
    {
        Vector3 dir = transform.right * Input.GetAxis("Horizontal");
        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);
        if (dir.x < 0)
        {
            transform.localScale = new Vector3(-0.25f, 0.25f, 1);
        }
        else
        {
            transform.localScale = new Vector3(0.25f,0.25f,1);
        }
    }

    private void Jump()
    {
        rigibody.AddForce(transform.up * jump, ForceMode2D.Impulse);
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Horizontal"))
            Run();
        if (Input.GetButtonDown("Jump"))
            Jump();

    }


}
