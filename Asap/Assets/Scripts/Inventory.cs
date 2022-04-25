using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{

    [SerializeField] private PickableItem[] items;
    [SerializeField] private GameObject inventory;

    const int size = 3;

    private void Awake()
    {
        items = new PickableItem[size];
    }

    public void AddItem(PickableItem item)
    {

        for (int i = 0; i < size; i++)
        {
            if (items[i] == null)
            {
                items[i] = item;
                ShowItem(item.GetSprite(), i);
                break;
            }
        }
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            inventory.SetActive(!inventory.activeSelf);
        }
    }

    private void ShowItem(Sprite sprite, int index)
    {
        inventory.transform.GetChild(index).GetChild(0).GetComponent<Image>().sprite = sprite;
    }

    public bool CheckItem(int index)
    {
        return items[index] != null;
    }

    public bool IsFull()
    {
        for (int i = 0; i < size; i++)
        {
            if (CheckItem(i) == false)
            {
                return false;
            }
        }
        return true;
    }

    public void RemoveItems()
    {
        for (int i = 0; i < size; i++)
        {
            items[i] = null;
            inventory.transform.GetChild(i).GetChild(0).GetComponent<Image>().sprite = null;
        }
    }
}
