using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.AI;

using static UnityEngine.Random;

using UnityEngine.UI;

public class CombateIA: Luchador
{
	
	Luchador objective;	
	
	Turno turn;
	
	public void calcularaAtaqueFinal()
    {
       Debug.Log("Test");
    }
	
	void Start()
	{
		
		turn = GetComponentInParent<Turno>();
		
	}
	
	public void Update(){

		if (isMyTurn)
		{
			
			objective = turn.SelectEnemyObjective(0, false);

			transform.LookAt(objective.transform);

            if (!chose)
            {
				turnoTerminado = false;
				
				StartCoroutine("IEAttackAnim");
				
				chose = true;

            }
			
		}
		
	}
	
	IEnumerator IEAttackAnim()
	{
    
		transform.position += transform.forward*20f;

		Debug.Log("--------------------------------------------- "+gameObject.name + " ataca a " + objective.name+" con damage: "+stats.damage);

		MakeDmg(false,objective.gameObject, stats.damage);		
    
		yield return new WaitForSeconds(1f);
		
		transform.position += transform.forward * -20f;

		turnoTerminado = true;

	}
	
}