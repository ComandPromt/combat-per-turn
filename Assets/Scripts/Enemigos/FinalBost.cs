using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class FinalBost : Enemigo
{  

	Aliado ali= new Aliado();
		
    void Start()
    {

	    nivel=100;
		
        vida = 99999f;
		
        armadura = 9999f;
		
        damage = 88855f;
		
		canTalk=true;
		
		missionObjetive=true;
		
		Debug.Log("Esta es tu ultima parada");
		
		calcular_escenario();
		
    }

	void Update()
    {
		
        Debug.Log("No me venceras");
		
		while (ali.vida>50){
			
			if(ali.vida>500){		
				atacar(ali);
			}
			
			else{
				ali.vida=50;
				Debug.Log("Me venciste");
				muerto=true;
			}
			
		}
		
		if(!muerto){
			
			// Ataque final
		
			ali.vida=0;
		
			// Lanzar voz (archivo de sonido)
		
			Debug.Log("Game Over");
		
			// Veo cuantos luchadores de mi equipo han sido derrotados
			
			// List  derrotados= new List();
			
			/*
			
				for(int i=0;i<6;i++){
					
					if(luchadores[i].vida==0){
						derrotados[]=luchadores[i];
					}
					
				}
				
				for(int i=0;i<derrotados.size();i++){
					
					luchadores[i].tiempoRecuperacion=saberTiempoRecuperacion(derrotados[i]);
					
				}
			
			function saberTiempoRecuperacion(int idLuchador){
				
				// Tiempo en minutos
				
				float tiempoRecuperacion;
				
				swtich(idLuchador){
					
					case 1:
					case 2:
					tiempo=2;
					break;
									
					case 4:
						tiempo=1.5f;
					break;
					
					default:
						tiempo=10;
					break;
					
				}
				
				return tiempoRecuperacion;
			}
						
			*/
					
		}
		
	}
 
	public void LoadScene(int num){
		
		// Scene(num).load();
		
	}
 
	public void calcular_escenario(){

		/*

		Math.random(0,1);
		
		if(num>0){
		
		try{
				LoadScene(num);
			}
			
			catch(Exception e){
				
			}
		}
				
		*/
				
	}
 
	public void atacar(Aliado ali){
	
		if(ali.vida>0){
			
			Debug.Log("Preparate para perder");

			for(int i=0;i<100;i++){
				ali.vida-=10;
			}
			
			
		}
		
		else{
			
			Debug.Log("Do you want continue? y/n");
			
			/*
			
			if(resp!=0){
				
				muerto=true;
				
				transform.posicionar(x,y,x);
				
			}

			*/
			
		}
		
	}
  
}