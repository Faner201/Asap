using UnityEngine;

public class Light : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) 
    {
        other.GetComponent<Monster>()?.Death();
    }
}
