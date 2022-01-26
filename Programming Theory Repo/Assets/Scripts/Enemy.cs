using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float wanderingDistance;
    [SerializeField] float startingPoint;

    public virtual void EnemyMove()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time, wanderingDistance)+startingPoint, transform.position.y, transform.position.z); 
    }

    public virtual void EffectOnPlayer(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        { 
            Destroy(collision.gameObject);
            Destroy(GameObject.Find("Player"));
        }

    }    
}
 
