using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower_Projectile : Tower
{
    [Header("Projectile tower stuff")]
    public GameObject projectile;
    public Vector3 spawnPoint = Vector3.up;
    public float projSpeed = 10;
    public float explosionRadius = 4;


    protected override void DamageTarget()
    {
        //Check if we even have a target to shoot
        if (currentTarget != null)
        {
            //Check if the distance of the target to us is less than our max range
            if (Vector3.Distance(transform.position, currentTarget.transform.position) < range)
            {
                //Spawn a new object at the spawn point, with a default rotation.
                GameObject newProj = Instantiate(projectile, transform.position + spawnPoint, Quaternion.identity);

                //Make projectile look at the target
                newProj.transform.LookAt(currentTarget.transform);

                //make it move forwards
                newProj.GetComponent<Rigidbody>().velocity = newProj.transform.forward * projSpeed;

                //Tell the projectile what spawned it
                newProj.GetComponent<Projectile>().origin = this;

                //Look towards the target
                transform.LookAt(currentTarget.transform);
            }
            else
            {
                //Current target not in range? Then look for a new one instead.
                FindTarget();
            }
        }
        else
        {
            //Look for a new target and try again next time
            FindTarget();
        }
        //Debug.Log("Tower is shooting");
    }



    public void HitTarget(Vector3 collidePoint)
    {
        Collider[] nearbyColliders;         //Store a temp list of all nearby colliders
        List<Creep> nearbyCreeps = new List<Creep>();   //Store a temp list of all nearby creeps


        //Find all colliders within range and store it in the array
        nearbyColliders = Physics.OverlapSphere(collidePoint, range);


        //Filter through the array and make a list of creeps.
        for (int i = 0; i < nearbyColliders.Length; i++)
        {
            Creep tempCreep = nearbyColliders[i].GetComponent<Creep>();

            //Avoid the null reference eception error when we inevitably check the ground and there's no creep component on it.
            if (tempCreep != null)
            {
                //nearbyCreeps.Add(tempCreep);
                tempCreep.TakeDamage(damage);
            }
        }
    }

}
