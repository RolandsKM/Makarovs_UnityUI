using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class IzmeraUnPlatumaMaiņa : MonoBehaviour {
	public GameObject mainigaisAttels;
	public GameObject MainigasiG;
	public GameObject sliderisIzmes;
	public GameObject sliderisAugstums;
	public Sprite[] AtteluMasivs;
	public void mainitlielumu()
	{
		float pasreizejaVertiba = sliderisIzmes.GetComponent<Slider>().value;
		mainigaisAttels.transform.localScale = new Vector2(1f*pasreizejaVertiba, 1f);
	}
	public void mainitAukstumu()
	{
		float pasreizejaVertiba = sliderisAugstums.GetComponent<Slider>().value;
		mainigaisAttels.transform.localScale = new Vector2(1f, 1f*pasreizejaVertiba);
	}



	public void izkritosais(int skaitlis)
	{
		if (skaitlis == 0)

			MainigasiG.GetComponent<Image>().sprite = AtteluMasivs[0];
		else if (skaitlis == 1)
			MainigasiG.GetComponent<Image>().sprite = AtteluMasivs[1];
		else if (skaitlis == 2)
			MainigasiG.GetComponent<Image>().sprite = AtteluMasivs[2];
		else
			Debug.Log("Nev piesaistītais attels");
	}

}
