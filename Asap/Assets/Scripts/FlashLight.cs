using UnityEngine;

public class FlashLight : InterectiveItem
{
    [SerializeField] private GameObject _light;
    public override void Take()
    {
        _light.SetActive(true);
    }
}
