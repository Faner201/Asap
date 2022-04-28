using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
   private RectTransform rectTrans;
   public Canvas _canvas;
   private CanvasGroup canvasGroup;

   private void Start() 
   {
       rectTrans = GetComponent<RectTransform>();
       canvasGroup = GetComponent<CanvasGroup>();
   }

   public void OnBeginDrag(PointerEventData eventData)
   {
       canvasGroup.blocksRaycasts = false;
   }

   public void OnDrag(PointerEventData eventData)
   {
       rectTrans.anchoredPosition += eventData.delta / _canvas.scaleFactor;
   }

   public void OnEndDrag(PointerEventData eventData)
   {
        canvasGroup.blocksRaycasts = true;

   }

   public void OnPointerDown(PointerEventData eventData)
   {
   }
}
