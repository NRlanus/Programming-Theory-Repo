using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetector : MonoBehaviour
{
    public EnemyFollower enemyFollower;
    // Start is called before the first frame update
    void Start()
    {
        enemyFollower = gameObject.GetComponentInParent<EnemyFollower>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            enemyFollower.isDetected = true;
            Debug.Log("I see you");
        }
        
    }
     private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        enemyFollower.isDetected = false; 

    }  

}
