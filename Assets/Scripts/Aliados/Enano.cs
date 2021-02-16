using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enano : Aliado
{
    // Start is called before the first frame update
    void Start()
    {
        this.vida = 50f;
        this.armadura = 40f;
        this.damage = 20f;
        this.canTalk = true;
        
    }

}
