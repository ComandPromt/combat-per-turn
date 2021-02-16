using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Luchador: MonoBehaviour
{

	public void TakeDamage(float vida,float armadura,float dmgReceived)
    {
        vida = vida + armadura+(nivel/3f) - dmgReceived;
    }
	
    public virtual void MakeDmg(GameObject target, Vector3 myPosition, float dmg)
    {
        if (Vector3.Distance(target.transform.position,myPosition)<=damage) {

            if (!muerto) {
                dmg = dmg + (nivel / 3f);
                }
        }
    }
	
	void Update(){
		
	 float y = Input.GetAxis("Vertical") * 20f*Time.deltaTime;
		
        float x = Input.GetAxis("Horizontal") * 20f*Time.deltaTime;

		transform.Translate(y,0.0f,-x);
	
	}
	
	public Luchador(){
	}
	
	public Luchador(int number,int level){
		
		this.nivel=level;
				
		switch(number){
			
			case 1:
			
				this.vidaBase=100;
			
				this.mana=20;
			
				this.armadura=200;
			
				this.attackspeed=10;
			
				this.damage=200;
			
				this.critRate=10;
			
				this.habilidades=new int[] { 1};
			
			break;
			
			case 2:
			
				this.vidaBase=80;
			
				this.mana=40;
						
				this.armadura=150;
			
				this.attackspeed=20;
			
				this.damage=150;
			
				this.critRate=5;
			
				this.habilidades=new int[] { 1, 2 };
			
			break;
			
		}
		
	}
	
}