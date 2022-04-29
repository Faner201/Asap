using UnityEngine;
 
public class MonsterAnimation : MonoBehaviour
{
    private Monster _movement;
    private Animator _animator;
 
    private float offset = 1f;
 
 
    private void Start()
    {
        _movement = GetComponent<Monster>();
        _animator = GetComponentInChildren<Animator>();
    }
 
    private void Update()
    {
        Animate(_movement.Velocity);
    }
 
    private void Animate(Vector2 velocity)
    {
        if (velocity.x == 0)
        {
            _animator.Play("Stay");
        }
        else
        {
            _animator.Play("Run");
            int modif = velocity.x > 0 ? -1 : 1;
            transform.localScale = new Vector3(modif, 1, 1);
        }
    }
}