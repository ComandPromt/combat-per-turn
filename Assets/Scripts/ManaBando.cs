using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaBando : MonoBehaviour
{
	
	public float mana, manaMax;
	
	public Image barraDeMana;

    public void UpdateBarraMana(float m, float mMax)
    {

		this.mana = m;
		
		this.manaMax = mMax;

		barraDeMana.fillAmount=this.mana/this.manaMax;	
				
    }
	
}