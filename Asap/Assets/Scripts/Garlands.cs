using UnityEngine;
using UnityEngine.UI;

public class Garlands : InterectiveItem
{
    [SerializeField] private Image imageGarlands;

    public override void Interact()
    {
        imageGarlands.gameObject.SetActive(true);
    }
    
}
