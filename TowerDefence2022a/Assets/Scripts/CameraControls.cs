using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour
{
    float speed = 5;

    public float maxX = 20;
    public float minX = -20;
    
    public float maxY = 20;
    public float minY = 5;

    public float maxZ = 20;
    public float minZ = -20;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Controls();
        ConstrainCamera();
    }

    void Controls()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime * Input.GetAxis("Horizontal"), Space.World);

        transform.Translate(Vector3.forward * speed * Time.deltaTime * Input.GetAxis("Vertical"), Space.World);

        transform.Translate(Vector3.up * speed * -30 * Time.deltaTime * Input.GetAxis("Mouse ScrollWheel"), Space.World);
    }




    /// <summary>
    /// Keeps the camera within the borders we have assigned
    /// </summary>
    void ConstrainCamera()
    {
        float xPos = transform.position.x;              //get current x.position of the camera
        xPos = Mathf.Clamp(xPos, minX, maxX);           //Clamp it to within the borders

        float yPos = transform.position.y;              //get current x.position of the camera
        yPos = Mathf.Clamp(yPos, minY, maxY);           //Clamp it to within the borders

        float zPos = transform.position.z;              //get current x.position of the camera
        zPos = Mathf.Clamp(zPos, minZ, maxZ);           //Clamp it to within the borders

        transform.position = new Vector3(xPos, yPos, zPos);
    
    }


}
