using UnityEngine;
using UnityEngine.Video;

public class VideoStart : MonoBehaviour
{
    private double time;
    private double currentTime;

    private void Start() 
    {
        time = gameObject.GetComponent<VideoPlayer>().clip.length;
        Time.timeScale = 0f;
    }

    private void Update()
    {
        currentTime = gameObject.GetComponent<VideoPlayer>().time;
        if(currentTime + 0.4f >= time)
        {
            gameObject.SetActive(false);
            Time.timeScale = 1f;
        }
    }
}
