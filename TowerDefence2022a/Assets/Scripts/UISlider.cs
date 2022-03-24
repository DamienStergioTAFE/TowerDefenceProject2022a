using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UISlider : MonoBehaviour
{
    public TextMeshProUGUI textBox;
    public Image displayImage;
    public Color minColor, maxColor;
    public Slider thisSlider;

    public void DisplayNumber(float value)
    {
        // Sets the text box
        textBox.text = value.ToString();

        // Makes a number between 0 and 1 
        float proportion = value / thisSlider.maxValue;

        // Interpoloate the colour with this proportion
        Color mixedColor = Color.Lerp(minColor, maxColor, proportion);

        // Change the color of the image
        displayImage.color = mixedColor;
    }






    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
