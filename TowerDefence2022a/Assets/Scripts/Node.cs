using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Manager manager;         //Game Manager
    public Material mat;            //Colour material
    public Color defaultColor;
    public GameObject spawnedTower; //The tower object that we spawned on this node
    public GameObject ghostTower;   //The ghost that appears when hovering over the node.
    MeshFilter meshFilter;

    void Start()
    {
        //Get the material on the object to change its colour.
        mat = GetComponent<Renderer>().material;

        defaultColor = mat.color;

        //Find the manager to know what tower to spawn
        manager = FindObjectOfType<Manager>();

        meshFilter = ghostTower.GetComponent<MeshFilter>();

        meshFilter.mesh = null;
    }

    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        /// If it doesn't have a tower already...
        /// Instantiate a gameobject on top of the node.
        /// The object will need to have a mesh renderer
        /// that mesh will match the currently selected tower
        /// the mesh will have a material that is transparent.

        meshFilter.sharedMesh = manager.towerPrefab.GetComponent<MeshFilter>().sharedMesh;



        mat.color = Color.red;
        if (Input.GetMouseButtonDown(0))
        {
            if(spawnedTower != null)        //This means we have a tower already
            {
                return;                     //...skip to the end
            }

            //Find out how much money the tower would cost
            float price = manager.towerData.price;

            if (manager.BuySomething(price) == false)
            {
                //if the price is too much for us, skip to the end.
                return;
            }


            //Debug.Log("I have been clicked");

            //Create a reference to a new gameobject we "spawn"
            //Specifically the manager's tower prefab
            GameObject newObject = Instantiate(manager.towerPrefab);

            //Keep track of the spawned tower by placing it in the variable.
            spawnedTower = newObject;

            //Set the colour of the tower's material to match the towerdata value
            spawnedTower.GetComponent<Renderer>().material.color = manager.towerData.towerColour;


            //Reassign the values for position on this new object
            //and make them match the node's position.
            newObject.transform.position = transform.position;

            //Now we get the tower component on that new object
            //and store it in another teporary variable
            Tower tower = newObject.GetComponent<Tower>();

            //Give it all of its stats based on the manager's template
            tower.damage = manager.towerData.damage;
            tower.range = manager.towerData.range;
            tower.fireRate = manager.towerData.fireRate;
        }

    }

    private void OnMouseExit()
    {
        mat.color = defaultColor;
        meshFilter.mesh = null;
    }


}
