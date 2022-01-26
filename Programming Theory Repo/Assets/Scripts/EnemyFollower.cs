using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollower : Enemy
{
    public GameObject playerGo;
    private Rigidbody enemyRb;

    [SerializeField] float speed; //current Speed 
    private Vector3 distanceFromPlayer;
    public bool isDetected  {get; set;}
   
    private void Start()
    {
        isDetected = false;
        enemyRb = GetComponent<Rigidbody>();
    }

    private void Update()
    {  
         EnemyMove();    
    }

    public override void EnemyMove()
    {
        if (isDetected && playerGo != null && playerGo.GetComponent<CharacterController>().enabled)
        {
            distanceFromPlayer =  new Vector3(playerGo.transform.position.x, transform.position.y, 0) - transform.position;
             transform.Translate(speed * Time.deltaTime * distanceFromPlayer.normalized);    
        } 
    }
 
    private void OnCollisionEnter(Collision collision) 
    { 
        EffectOnPlayer(collision);  
    }
    
    //polimorphism
    //if the enemy collides with the player it disables characterController
    public override void EffectOnPlayer(Collision collision)
    {
        playerGo.GetComponent<CharacterController>().enabled = false;
    }



}



