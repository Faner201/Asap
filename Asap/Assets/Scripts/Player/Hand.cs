using UnityEngine;

public class Hand : MonoBehaviour
{
    [SerializeField] private Vector2 size;
    [SerializeField] private LayerMask itemLayer;
    [SerializeField] private Inventory inventory;
    public bool hand;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Collider2D collider = Physics2D.OverlapBox(transform.position, size, 0, itemLayer);
            if (collider != null)
            {
                if (collider.GetComponent<PickableItem>())
                {
                    inventory.AddItem(collider.GetComponent<PickableItem>());
                    collider.gameObject.SetActive(false);
                }
                else if (collider.GetComponent<HandPicked>())
                {
                    TakeItem(collider.transform);
                }
                else if(collider.GetComponent<InterectiveItem>())
                {
                    collider.GetComponent<InterectiveItem>().Interact();
                }
            }
        }
    }

    public void TakeItem(Transform item)
    {
        hand = true;
        item.SetParent(transform);
        item.position = transform.position;
        item.GetComponent<HandPicked>().Take();
        item.gameObject.layer = LayerMask.NameToLayer("element taken");
    }
}
