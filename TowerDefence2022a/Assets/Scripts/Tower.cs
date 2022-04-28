using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum TargetType { close, far, mostHealth, leastHealth, fastest, slowest }

public class Tower : MonoBehaviour
{
    // Variables for a tower
    public float range;
    public float damage;
    public float fireRate;
    public TargetType targetType = TargetType.close;    //How it decides what unit to attack

    public Creep currentTarget;     //What we are shooting at now


    // Start is called before the first frame update
    void Start()
    {
        FindTarget();
        InvokeRepeating("DamageTarget", 0, fireRate);
    }

    protected void FindTarget()
    {
        // Search for creep within range

        Collider[] colliders = Physics.OverlapSphere(transform.position, range);

        //Find an entity in this
        foreach (Collider item in colliders)
        {
            //Search for a creep component
            Creep thisCreep = item.GetComponent<Creep>();

            //If we found one...
            if (thisCreep != null)
            {
                //Assign our current target to this creep
                currentTarget = thisCreep;
            }
        }
    }

    protected virtual void DamageTarget()
    {
        //Check if we even have a target to shoot
        if(currentTarget != null)
        {
            //Check if the distance of the target to us is less than our max range
            if(Vector3.Distance(transform.position, currentTarget.transform.position) < range)
            {
                //Deal damage to the currently selected target
                currentTarget.TakeDamage(damage, this);

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


    // Update is called once per frame
    void Update()
    {

    }
}
