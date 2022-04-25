using UnityEngine;

public class LockUI : MonoBehaviour
{
    private ScrollLock[] clocks;
    [SerializeField] private PickableItem _object;
    [SerializeField] private Inventory inventory;
    
    public void Check()
    {
        foreach (var clock in clocks)
        {
            if(!clock.IsCorrect())
            {
                return;
            }
            Debug.Log("hihihi");
        }
        inventory.AddItem(_object);
        gameObject.SetActive(false);
    }

    private void Start()
    {
        clocks = new ScrollLock[transform.childCount];
        for(int i = 0; i < clocks.Length; i++)
        {
            clocks[i] = transform.GetChild(i).GetComponent<ScrollLock>();
        }
    }
}
