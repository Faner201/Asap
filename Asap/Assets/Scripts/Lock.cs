using UnityEngine;

public class Lock : MonoBehaviour
{
    private ScrollLock[] clocks;


    private void Start() 
    {
        clocks = new ScrollLock[transform.childCount];
        for(int i = 0; i < clocks.Length; i++)
        {
            clocks[i] = transform.GetChild(i).GetComponent<ScrollLock>();
        }
    }
}
