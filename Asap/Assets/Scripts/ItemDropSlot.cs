using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemDropSlot : MonoBehaviour, IDropHandler
{
    [SerializeField] private Image _image;
    [SerializeField] private Sprite _sprite;
   public void OnDrop(PointerEventData eventData)
   {
       if(eventData.pointerDrag != null)
       {
           eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = new Vector2(-625,-825);
           eventData.pointerDrag.transform.localScale = new Vector3(2,2,1);
           _image.sprite = _sprite;
           gameObject.SetActive(false);
       }
   }

   private void Update() 
   {
       if(Input.GetKey(KeyCode.G))
       {
            transform.parent.gameObject.SetActive(false);
       }
   }
}
