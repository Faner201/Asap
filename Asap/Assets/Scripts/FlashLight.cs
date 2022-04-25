using UnityEngine;

public class FlashLight : HandPicked
{
    [SerializeField] private GameObject _light;
    public override void Take()
    {
        _light.SetActive(true);
    }
}
