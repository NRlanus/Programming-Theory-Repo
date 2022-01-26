using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBounce : Enemy // INHERITANCE
{
    private Rigidbody enemyRb;
    [SerializeField] float forceSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        EnemyMove(); //ABSTRACTION
    }
    public override void EnemyMove() // POLYMORHISM
    {
        enemyRb.AddForce(Vector3.right * forceSpeed * Time.deltaTime, ForceMode.Impulse);
    }

    //if the enemy goes out of the screen it´s destroyed
    void ConstraintsEnemyPosition()
    {
        if(transform.position.x<10)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        EffectOnPlayer(collision);
    }
}
