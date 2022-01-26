using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    [SerializeField] float startTime;
    [SerializeField] float repeatTime;
    public GameObject enemyBouncer;
    public GameObject playerGo;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("InstantiateEnemy", startTime, repeatTime);  
    }

    // Update is called once per frame
    void Update()
    {
         
    }

    void InstantiateEnemy()
    {
        Instantiate(enemyBouncer,transform.position,transform.rotation);
    }
}
