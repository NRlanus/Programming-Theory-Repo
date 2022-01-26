using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWandering : Enemy

{
    private void Update()
    {
        EnemyMove();
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        EffectOnPlayer(collision);
    }

}
    
