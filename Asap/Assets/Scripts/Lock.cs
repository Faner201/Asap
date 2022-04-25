using UnityEngine;

public class Lock : InterectiveItem
{
    [SerializeField] private LockUI lockUI;
    public override void Interact()
    {
       lockUI.gameObject.SetActive(true);
    }
}
