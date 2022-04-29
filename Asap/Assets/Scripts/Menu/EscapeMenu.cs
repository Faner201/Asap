using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapeMenu : MonoBehaviour
{
    private const int sceneId = 0;

    private void Home(int sceneId)
    {
        SceneManager.LoadScene(sceneId);
    }

    private void Update() 
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            Home(sceneId);
        }
    }
}
