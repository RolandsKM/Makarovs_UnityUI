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
	float pasreizejaVertiba=1;
	float pasreizejaVertiba2=1;
	public void mainitlielumu()
	{
		 pasreizejaVertiba = sliderisIzmes.GetComponent<Slider>().value;
		mainigaisAttels.transform.localScale = new Vector2(1f*pasreizejaVertiba, pasreizejaVertiba2);
	}
	public void mainitAukstumu()
	{
		 pasreizejaVertiba2 = sliderisAugstums.GetComponent<Slider>().value;
		mainigaisAttels.transform.localScale = new Vector2(pasreizejaVertiba, 1f*pasreizejaVertiba2);
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
