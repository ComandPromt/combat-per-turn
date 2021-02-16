using System.Runtime;
using System.Collections;
using UnityEngine;
public class Aliado : Luchador
{
	Transform player;
   
    UnityEngine.AI.NavMeshAgent agent;

    public Vector3 destinationPoint;
  
    public int vidaMaxima=100;
	
	public float vida;
	 
	public float speed = 10000;
	
	int turno;
	
    void Start()
    {

		Luchador player = new Luchador(1,1);
		
		Turno turn= new Turno();
		
		turno=turn.getTurno();
		
		// Empiezo por un random, si es 1 empiezan los aliados, sino empiezan los enemigos
		
		vida=vidaMaxima;
		
        agent= GetComponent<UnityEngine.AI.NavMeshAgent>();
		
		agent.speed = speed;

    }

    void Update()
    {


        if(Target.){}

		switch(turno){
			
			case 1:
			
				// Eligo el target, es decir, al jugador enemigo y lo ataco
			
				// Miro la posicion del tag enemigo+numero y le resto una vida
			
				turno=2;
			


			break;
			
			case 2:
				// Miro la posicion del tag aliado+numero y le resto una vida
				turno=1;
			
			break;
								
		}


    }

    void OnTriggerEnter(Collider obj) {


    }
}