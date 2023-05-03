using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvataruMaina : MonoBehaviour {
	[Header("Sprite To Change")]
	public SpriteRenderer BodyPart;
	[Header("Sprite to Cycle Through")]
	public List<Sprite> options = new List<Sprite>();
	// Use this for initialization
	private int TagadejaIzvele = 0;
	public void NakamaIzvele()
	{
		TagadejaIzvele++;
		if(TagadejaIzvele>=options.Count) {
			TagadejaIzvele = 0;
		}
		BodyPart.sprite = options[TagadejaIzvele];
	}
	public void ieprieksejaizvele()
	{
		TagadejaIzvele--;
		if (TagadejaIzvele <= 0)
		{
		TagadejaIzvele=options.Count-1;
		}
		BodyPart.sprite = options[TagadejaIzvele];
	}

}
