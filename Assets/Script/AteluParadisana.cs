using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AteluParadisana : MonoBehaviour {
	public Toggle toggle, toggle2, TogglePet;
	public GameObject Male;
	public GameObject Female; 
	public GameObject Pet;
	public GameObject Mati;
	public GameObject Mati2;
	private Image image;
	private Image image2;
	private void Start()
	{
		image = Male.GetComponent<Image> ();
		image2 = Female.GetComponent<Image> ();
		image = Mati.GetComponent<Image> ();
		image2 = Mati2.GetComponent<Image> ();
		image = Pet.GetComponent<Image> ();
		toggle.onValueChanged.AddListener (OnToggleValueChanged);
		toggle2.onValueChanged.AddListener (OnToggleValueChanged2);
		TogglePet.onValueChanged.AddListener (OnToggleValueChangedPet);

	}
	private void OnToggleValueChanged(bool value){
		Male.SetActive (value);
		Mati.SetActive (value);
	}

	private void OnToggleValueChanged2(bool value){
		Female.SetActive (value);
		Mati2.SetActive (value);
	}
	private void OnToggleValueChangedPet(bool value){
		Pet.SetActive (value);

	}

}
