using UnityEngine;
using UnityEngine.EventSystems;

public class Dropscript : MonoBehaviour
{
   public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Item Dropped on Slot");

        // Get the dragged object
        GameObject draggedObject = eventData.pointerDrag;

        if (draggedObject != null)
        {
            // Snap the dragged object to this slot
            RectTransform draggedRectTransform = draggedObject.GetComponent<RectTransform>();
            draggedRectTransform.anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
    }
}
