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
        }
        gameObject.SetActive(false);
        inventory.AddItem(_object);
    }

    private void Start()
    {
        clocks = new ScrollLock[transform.childCount];
        for(int i = 0; i < clocks.Length; i++)
        {
            clocks[i] = transform.GetChild(i).GetComponent<ScrollLock>();
        }
    }
    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.G))
        {
            gameObject.SetActive(false);
        }
    }
}
