using UnityEngine;

public class ObjectHold : MonoBehaviour
{
    [SerializeField] private Vector2 size;
    [SerializeField] private LayerMask itemLayer;
    public bool hold;

    public Transform hand;
    private InterectiveItem interectiveItem;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Collider2D collider = Physics2D.OverlapBox(transform.position, size, 0, itemLayer);
            if (collider != null)
            {
                TakeItem(collider.transform);
            }
        }
    }

    public void TakeItem(Transform item)
    {
        hold = true;
        item.SetParent(hand);
        item.position = hand.position;
        interectiveItem = item.GetComponent<InterectiveItem>();
        interectiveItem.Take();
        interectiveItem.gameObject.layer = LayerMask.NameToLayer("element taken");
    }
}
