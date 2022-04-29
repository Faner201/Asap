using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoEnd : MonoBehaviour
{
    private double time;
    private double currentTime;
    [SerializeField] private Inventory inventory;
    [SerializeField] private VideoPlayer videoEnd;
    private const int sceneId = 0;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(inventory.CheckItem(1) && other.gameObject.CompareTag("Player"))
        {
            videoEnd.gameObject.GetComponent<VideoPlayer>().Play();
            videoEnd.playOnAwake = true;
            time = gameObject.GetComponentInChildren<VideoPlayer>().clip.length;
        }
    }

    private void Update()
    {
        if(videoEnd.playOnAwake)
        {
            currentTime = gameObject.GetComponentInChildren<VideoPlayer>().time;
            if(currentTime >= time)
            {
                gameObject.SetActive(false);
                SceneManager.LoadScene(sceneId);
            }
        }
    }
}