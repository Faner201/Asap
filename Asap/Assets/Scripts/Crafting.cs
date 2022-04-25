using UnityEngine;
using UnityEngine.UI;

public class Crafting : MonoBehaviour
{
    [SerializeField] private GameObject crafting;
    [SerializeField] private Text[] slots;
    [SerializeField] private GameObject torch;
    [SerializeField] private Hand hand;
    private Inventory inventory;

    const int size = 3;

    private void Awake()
    {
        inventory = GetComponent<Inventory>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            crafting.SetActive(!crafting.activeSelf);
            SlotStatus();
        }
    }

    private void SlotStatus()
    {
        for (int i = 0; i < size; i++)
        {
            if (inventory.CheckItem(i))
            {
                slots[i].text = "1/1";
                slots[i].color = new Color(0.38501f, 0.6792453f, 0, 1);
            }
        }
    }
    public void Create()
    {
        if (inventory.IsFull())
        {
            inventory.RemoveItems();
            GameObject createdItem = Instantiate(torch);
            inventory.AddItem(createdItem.GetComponent<PickableItem>());
            hand.TakeItem(createdItem.transform);
        }
    }
}
