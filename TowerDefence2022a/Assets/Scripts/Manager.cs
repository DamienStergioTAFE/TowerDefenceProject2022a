using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public int lives;
    public float money;

    public GameObject creepPrefab;
    public GameObject towerPrefab;

    public CreepSO creepData;


    // Start is called before the first frame update
    void Start()
    {
        //Spawn in the new creep and get a reference to it
        GameObject newObject = Instantiate(creepPrefab);

        //Get the component on it
        Creep creep = newObject.GetComponent<Creep>();

        //Set all the important values
        creep.maxHealth = creepData.maxHealth;
        creep.speed = creepData.speed;
        creep.armour = creepData.armour;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
