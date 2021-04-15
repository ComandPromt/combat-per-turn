using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaBando : MonoBehaviour
{
	
	public float vida, vidaMax;
	
	public Image barraDeVida;

    public void UpdateBarraVida(float v, float vMax)
    {

		this.vida = v;
		
		this.vidaMax = vMax;
	
		barraDeVida.fillAmount=this.vida/this.vidaMax;	
				
    }
	
}
