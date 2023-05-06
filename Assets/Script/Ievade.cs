using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Ievade : MonoBehaviour {

	public string teksts;
	public int Vecums;
	public GameObject IevadesLauks;
	public GameObject IevadesLauksVecums;
	public GameObject TekstaAttelosana;

	int indekss;
	public void UzglabaTekstu()
	{
		
		teksts = IevadesLauks.GetComponent<InputField>().text;
		int.TryParse(IevadesLauksVecums.GetComponent<InputField>().text, out Vecums);
		TekstaAttelosana.GetComponent<Text>().text = "Spélétájs " + teksts + " Ir " + Vecums.ToString() + " Gadus Vecs!";


	}

}
