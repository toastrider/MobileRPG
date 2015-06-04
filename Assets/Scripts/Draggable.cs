using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

	public Transform returnParent = null;

	public void OnBeginDrag(PointerEventData eventData) {
		//Debug.Log ("OnBeginDrag");

		returnParent = this.transform.parent;
		this.transform.SetParent (this.transform.parent.parent.parent);
		GetComponent<CanvasGroup> ().blocksRaycasts = false;
	}

	public void OnDrag(PointerEventData eventData) {
		//Debug.Log ("OnDrag");

		this.transform.position = eventData.position;
	}

	public void OnEndDrag(PointerEventData eventData) {
		//Debug.Log ("OnEndDrag");

		this.transform.SetParent (returnParent);
		GetComponent<CanvasGroup> ().blocksRaycasts = true;
	}
}
