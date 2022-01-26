using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWandering : Enemy  // INHERITANCE

{
    private void Update()
    {
        EnemyMove(); //ABSTRACTION
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        EffectOnPlayer(collision);
    }

}
    
