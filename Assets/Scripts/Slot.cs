using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler {

	public void OnPointerEnter(PointerEventData eventData) {
		//Debug.Log ("OnPointerEnter");
	}

	public void OnPointerExit(PointerEventData eventData) {
		//Debug.Log ("OnPointerExit");
	}

	public void OnDrop(PointerEventData eventData) {
		Debug.Log (eventData.pointerDrag.name + " was dropped on " + gameObject.name);

		Draggable d = eventData.pointerDrag.GetComponent<Draggable> ();
		if (d != null) {
			if (this.transform.childCount == 1) {
				Debug.Log (this.transform.GetChild(0).name + " was moved to " + d.returnParent);
				this.transform.GetChild(0).SetParent(d.returnParent);
				d.returnParent = this.transform;
			}
		}
	}
}
