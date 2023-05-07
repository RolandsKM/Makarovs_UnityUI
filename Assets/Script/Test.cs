using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Test : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler{
	private RectTransform framsformKomponents;
	private CanvasGroup Group;
	public Canvas Kanva;
	void Start()
	{
		framsformKomponents = GetComponent<RectTransform>();
		Group = GetComponent<CanvasGroup> ();
	}
	public void OnPointerDown(PointerEventData notikums)
	{
		Debug.Log("Izdarīts peles klišķis uz objekta!");

	}
	public void OnBeginDrag(PointerEventData notikums){
		Debug.Log("Uzsākta objektu vilkšana");
		Group.alpha = .6f;
		Group.blocksRaycasts = false;
	}
	public void OnDrag(PointerEventData notikums)
	{
		Debug.Log("Notiek objektu Pārvietošana");
		framsformKomponents.anchoredPosition += notikums.delta / Kanva.scaleFactor;
	}
	public void OnEndDrag(PointerEventData notikums)
	{
		Debug.Log("Pabeikta objektu vilkšana ");
		Group.alpha = 1f;
		Group.blocksRaycasts = true;
	}
}