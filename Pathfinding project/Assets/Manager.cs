using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Manager : MonoBehaviour
{
    public Vector3 spawnPoint;
    public Vector3 endPoint;
    public GameObject creepPrefab;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newCreep = Instantiate(creepPrefab, spawnPoint, Quaternion.identity);

        newCreep.GetComponent<NavMeshAgent>().SetDestination(endPoint);

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(spawnPoint, 0.5f);
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(endPoint, 0.5f);
    }

}
