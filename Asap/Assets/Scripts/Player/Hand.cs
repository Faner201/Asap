using UnityEngine;

public class Hand : MonoBehaviour
{
    [SerializeField] private Vector2 size;
    [SerializeField] private LayerMask itemLayer;
    [SerializeField] private Inventory inventory;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Collider2D collider = Physics2D.OverlapBox(transform.position, size, 0, itemLayer);
            if (collider != null)
            {
                if (collider.GetComponent<PickableItem>())
                {
                    Debug.Log("ХУЙ1");
                    inventory.AddItem(collider.GetComponent<PickableItem>());
                    collider.gameObject.SetActive(false);
                }
                else if (collider.GetComponent<HandPicked>())
                {
                    Debug.Log("ХУЙ2");
                    TakeItem(collider.transform);
                }
                else if(collider.GetComponent<InterectiveItem>())
                {
                    Debug.Log("ХУЙ3");
                    collider.GetComponent<InterectiveItem>().Interact();
                }
            }
        }
    }

    public void TakeItem(Transform item)
    {
        item.SetParent(transform);
        item.position = transform.position;
        item.GetComponent<HandPicked>().Take();
        item.gameObject.layer = LayerMask.NameToLayer("element taken");
    }
}
