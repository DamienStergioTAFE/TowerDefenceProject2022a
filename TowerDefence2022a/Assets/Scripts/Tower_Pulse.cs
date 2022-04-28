using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower_Pulse : Tower
{

    protected override void DamageTarget()
    {
        Collider[] nearbyColliders;         //Store a temp list of all nearby colliders
        List<Creep> nearbyCreeps = new List<Creep>();   //Store a temp list of all nearby creeps


        //Find all colliders within range and store it in the array
        nearbyColliders = Physics.OverlapSphere(transform.position, range);


        //Filter through the array and make a list of creeps.
        for (int i = 0; i < nearbyColliders.Length; i++)
        {
            Creep tempCreep = nearbyColliders[i].GetComponent<Creep>();

            //Avoid the null reference eception error when we inevitably check the ground and there's no creep component on it.
            if (tempCreep != null)
            {
                //nearbyCreeps.Add(tempCreep);
                tempCreep.TakeDamage(damage, this);
            }
        }
    }

}
