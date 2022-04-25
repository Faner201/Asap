using UnityEngine;

public abstract class PickableItem : MonoBehaviour
{   
    public Sprite GetSprite()
    {
        return GetComponentInChildren<SpriteRenderer>().sprite;
    }
    
}
