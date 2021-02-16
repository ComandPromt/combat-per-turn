using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class Buho : Aliado
{  

    void Start()
    {
 		this.vida = 50f;
        this.armadura = 40f;

        this.damage = 20f;
        this.canTalk = true;

    }
     
	public void GameOver(){
		Debug.Log("Suerte la proxima vez");
	}
 
	public void atacar(Enemigo enemigo, int id){
		
		/*
		
		if(enemigo.size()>0){
			
			if(vida>0){
				
				Debug.Log("Es mi turno");
				
				// List <String> damage= api.response("https://heroku.com/juego.php?id_enemigo=id;
				
				//enemigo.vida-=damage[0];	
				
				if(enemigo.vida==0){
					
					Debug.Log("You Win");
					
					LoadScene('Hurtz');
					
					Debug.Log("Completaste el modo historia, como recompensa recibiras el caballero legendario perdido");
					
					UPDATE JUGADORES_EQUIPO SET Luchadores=1 ON user_id=1;
					
					if(nivel==30){
						
						Debug.Log("Tienes disponible el bosque púrpura, en él recibirás grandes recompensas");
						
					}
					
					else{
						Debug.Log("LLega al nivel 30 para desbloquear la zona gorila");
					}
					
				}
				
			}
			
			else{
				
				GameOver();
						
			}
		
		}
		
		else{
	
			GameOver();
		}
		
		*/
		
	}
	
}
