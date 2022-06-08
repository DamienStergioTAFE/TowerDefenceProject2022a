using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Tower_Projectile origin;

    private void OnCollisionEnter(Collision collision)
    {
        origin.HitTarget(transform.position);
        Destroy(gameObject);
    }

}
