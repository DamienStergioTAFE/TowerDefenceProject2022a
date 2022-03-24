using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Creep : MonoBehaviour
{
    public float health, maxHealth;
    public float speed;
    public float armour;
    public Vector3 objective;

    public Image heathBar;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        heathBar.fillAmount = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //Gets the direction we want to move in, and slightly moves this object in that direction.
        transform.position = Vector3.MoveTowards(transform.position,
            objective,
            speed * Time.deltaTime);
    }

    /// <summary>
    /// Called whenever something damages the creep
    /// </summary>
    /// <param name="value"> The incoming damage </param>
    public void TakeDamage(float value)
    {
        //Subtract health
        health = health - value;

        //Set the health bar to proportion
        heathBar.fillAmount = health / maxHealth;


        if (health <= 0)
        {
            //Die
            Destroy(gameObject);
        }
    }

}
