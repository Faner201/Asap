using UnityEngine;

public class Follower : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private Vector3 _offset;
    [SerializeField] [Range(0, 1)] private float _speed;

    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, _target.position + _offset, _speed);
    }
}