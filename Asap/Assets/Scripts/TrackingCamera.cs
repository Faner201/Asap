using UnityEngine;

public class TrackingCamera : MonoBehaviour
{
    public Hand hand;
    void Update()
    {
        if(hand.hand)
        {
            Tracking();
            InterectiveRotation();
        }
    }

    void Tracking()
    {
        var _direction = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        var angle = Mathf.Atan2(_direction.y, _direction.x) * Mathf.Rad2Deg + transform.position.z;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    void InterectiveRotation()
    {
        if (transform.parent.localScale.x < 0)
        {
            transform.rotation *= Quaternion.Euler(0, 0, 180);
        }
    }
}
