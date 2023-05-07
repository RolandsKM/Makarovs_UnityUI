using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AteluParadisana : MonoBehaviour {
	public Toggle toggle, toggle2, TogglePet, ToggleHat, ToggleSaite;
	public GameObject Male;
	public GameObject Female; 
	public GameObject Pet;
	public GameObject Hat;
	public GameObject bow;
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
		image = Hat.GetComponent<Image> ();
		image = bow.GetComponent<Image> ();
		toggle.onValueChanged.AddListener (OnToggleValueChanged);
		toggle2.onValueChanged.AddListener (OnToggleValueChanged2);
		TogglePet.onValueChanged.AddListener (OnToggleValueChangedPet);
		ToggleHat.onValueChanged.AddListener (OnToggleValueChangedCepure);
		ToggleSaite.onValueChanged.AddListener (OnToggleValueChangedBow);

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
	private void OnToggleValueChangedCepure(bool value){
		Hat.SetActive (value);

	}
	private void OnToggleValueChangedBow(bool value){
		bow.SetActive (value);

	}

}
