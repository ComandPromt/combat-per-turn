using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.AI;

using static UnityEngine.Random;

using UnityEngine.UI;

using TMPro;
 
public class Texto:MonoBehaviour{
 
	public static TextMeshProUGUI[] text;
	
	
	public void Start(){
	
		text = GameObject.Find("Canvas").GetComponentsInChildren<TextMeshProUGUI>();
	
		text[0].text = "";
	
		text[1].text = "";
	
	}
	
	public static IEnumerator IActText(bool bandoAliado,string s){
	
		int i;
	
		if (bandoAliado){
			
			i = 0;
			
		}
		
		else{
			
			i = 1;
			
		}
		
		text[i].text = s;
	
		yield return new WaitForSeconds(2f);
	
		text[i].text = "";
	
	}
 
}