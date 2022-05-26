using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect : MonoBehaviour
{
    Vector3 flatScale = new Vector3(5, 1, 5);


    // Start is called before the first frame update
    void Start()
    {
        LeanTween.scale(gameObject, flatScale, 0.2f).setLoopPingPong(1);


        LeanTween.color(gameObject, Color.clear, 0.4f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
