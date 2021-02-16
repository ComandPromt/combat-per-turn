
using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using static UnityEngine.Random;

public class Batalla: MonoBehaviour
{  

	int escenario;
	
	int turno;
	
	public int GetEscenario()
	{
		return this.escenario;
	}
  
	public void CalcularEscenario(){

		this.escenario=this.turno = Range(1, 3);
				
		//LoadScene(this.escenario);
				
	}
	
}