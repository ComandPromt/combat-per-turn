using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orco : Enemigo
{
    // Start is called before the first frame update
    void Start()
    {
        vida = 50f;
        armadura = 20f;
        damage = 15f;
        canTalk = false;
        
    }

}
