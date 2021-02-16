using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gorila : Enemigo
{  

	public float experience;
	
	GameObject target;

    void Start()
    {
		nivel=40;
        vida = 30f;
        armadura = 10f;
        damage = 3f;
		missionObjetive=true;
		dmgReceived=10.5f;
    }
    
	void Update()
    {
		
        Debug.Log("Grrrr");
    
	}
	
	public override void MakeDmg(GameObject target, Vector3 myPosition, float dmg){
		
		experience+=200;
		
		nivel=(int)experience/250;
		
	}
 
}
