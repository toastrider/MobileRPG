using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class PMController : MonoBehaviour, IPointerClickHandler {
	 
	public int speed = 10;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnPointerClick (PointerEventData eventData){
		//Debug.Log ("CLICKS!!!");

		GameObject menu = GameObject.Find ("PMMenu");
		menu.GetComponent<CanvasGroup> ().alpha = 1;
		menu.GetComponent<CanvasGroup> ().interactable = true;
	}
}
