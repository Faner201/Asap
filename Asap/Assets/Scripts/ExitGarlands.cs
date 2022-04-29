using UnityEngine;

public class ExitGarlands : MonoBehaviour
{
    private void Update() 
   {
       if(Input.GetKey(KeyCode.G))
       {
            gameObject.SetActive(!gameObject.activeSelf);
       }
   }
}
