using System.Collections;

using UnityEngine;

public class Habilidades : MonoBehaviour
{

	int index;
	
	string description;
	
	Habilidades(){
		
		switch(index){
		
			case 1:
				this.description="Cooldown 5";
			break;
			
			case 2:
				this.description="Cooldown 10";
			break;
			
			case 3:
				this.description="Cooldown 20";
			break;
			
			case 4:
				this.description="Cooldown 50";
			break;
			
			case 5:
				this.description="Cooldown 70";
			break;
			
			case 6:
				this.description="Attack with multiples guns";
			break;
		
		}
	
	}
	
}