using UnityEngine;
 
public class PlayerAnimator : MonoBehaviour
{
    private PlayerMovement _movement;
    private Animator _animator;
 
    private float offset = 1f;
 
 
    private void Start()
    {
        _movement = GetComponent<PlayerMovement>();
        _animator = GetComponentInChildren<Animator>();
    }
 
    private void Update()
    {
        Animate(_movement.Velocity);
    }
 
    private void Animate(Vector2 velocity)
    {
        if (velocity.y > 0)
        {
            _animator.Play("Stairs(Up)");
        }
        else if (velocity.y < 0)
        {
            _animator.Play("Stairs(Down)");
        } 
        else if (velocity.x == 0)
        {
            _animator.Play("Stand");
        }
        else if (velocity.x != 0)
        {
            _animator.Play("Run");
        }
 
        if (velocity.x > offset || velocity.x < -offset)
        {
            int modif = velocity.x > 0 ? 1 : -1;
            transform.localScale = new Vector3(modif * 1, 1, 1);
        }
    }
}