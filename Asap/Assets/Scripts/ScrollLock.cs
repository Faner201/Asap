using UnityEngine;
using UnityEngine.UI;

public class ScrollLock : MonoBehaviour
{
    [SerializeField] private Text textCount;
    [SerializeField] private int answer;
    private int count;

    public void Increment()
    {
        if(count == 9)
            count = 0;
        else
            count++;
        UpdateUI();
    }

    public void Dicrement()
    {
        if(count == 0)
            count = 9;
        else
            count--;
        UpdateUI();
    }

    private void UpdateUI()
    {
        textCount.text = count.ToString();
    }

    public bool IsCorrect()
    {
        return count == answer;
    }
}
