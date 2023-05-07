using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Info : MonoBehaviour {
	public GameObject TekstaAttelosana;
	private string[] fragmenti = {"Liepája", "Ríga", "Venspils" };
	private string[] Kads = {"Mamma: Mirusi\nTévs: Miris\nBráĺi/Másas: Nav", "Mamma: Dzíva\nStrádá Par Skolotáju\nTévs: Dzívs\nStrádá Par Dakteri\nBráĺi/Másas: Nav",
		"Mamma:Dzíva, Strádá Par Paváru\nTévs: Miris\nBrális: Dzívs"};
	private string[] Hobiji = {"Medít", "Peldét", "Lasít Grámatas", "Skriet", "Spélét spéles"};
	int indekss;
	public static string vards;
	public static string vecums;




	public void Tels()
	{
		indekss = Random.Range(0, fragmenti.Length);
		indekss = Random.Range(0, Kads.Length);
		indekss = Random.Range(0, Hobiji.Length);

		TekstaAttelosana.GetComponent<Text>().text = "Spélétájs " + vards + " Ir " + vecums + " Gadus Vecs!\n"+vards+"Dzimśanas Vieta: "+fragmenti[indekss]+
			"\n"+vards+" Gimenes Stávoklis:\n"+Kads[indekss]+"\n"+vards+" Hobiji\n"+Hobiji;


	}
}
