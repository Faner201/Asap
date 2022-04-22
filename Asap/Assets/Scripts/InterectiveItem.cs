using UnityEngine;

public abstract class InterectiveItem : MonoBehaviour
{

    public abstract void Take();

    public Sprite GetSprite()
    {
        return GetComponentInChildren<SpriteRenderer>().sprite;
    }
}