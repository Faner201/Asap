using UnityEngine;

public class LiftingObject : MonoBehaviour
{
    [SerializeField] private Vector2 InterectiveSize;

    [SerializeField] private LayerMask InterectiveItemLayer;

    [SerializeField] private Inventory inventory;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Collider2D collider = Physics2D.OverlapBox(transform.position, InterectiveSize, 0, InterectiveItemLayer);
            if (collider != null)
            {
                inventory.AddItem(collider.GetComponent<InterectiveItem>());
                collider.gameObject.SetActive(false);
            }
        }
    }

}
