using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIToggle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void TogglePressed()
    {
        Debug.Log("Toggle Pressed");
    }

    /// <summary>
    /// This is a function that reports the status of the toggle that pressed it.
    /// </summary>
    /// <param name="value"></param>
    public void TogglePressedBool(bool value)
    {
        // This is a way to check if a value is true or not
        if(value == true)   //Checking if the parameter we took in is true
        {
            Debug.Log("Toggle Pressed = True"); //Debug message
        }
        else                //If the last IF statement did not work, do this instead
        {
            Debug.Log("Toggle Pressed = False");//Second debug message
        }
    }

}
