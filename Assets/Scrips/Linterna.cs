using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UIElements;

public class Linterna : MonoBehaviour
{
    private Light2D light;
    
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light2D>();
    }

    public void On(Button seleccionado , Button afectado)
    {
        turn( seleccionado, afectado);
        light.intensity = 2; 
    }
    
    public void Off(Button seleccionado , Button afectado)
    {
        turn( seleccionado, afectado);
        light.intensity = 0;
    }

    void turn(Button seleccionado , Button afectado)
    {
        Color sel = seleccionado.style.backgroundColor.value;
        Color afe = seleccionado.style.backgroundColor.value;
        if (seleccionado.text == "ON")
        {
            seleccionado.style.backgroundColor = new StyleColor(Color.green);
            afectado.style.backgroundColor = new StyleColor(Color.grey);
        }
        if (seleccionado.text == "OFF")
        {
            seleccionado.style.backgroundColor = new StyleColor(Color.red);
            afectado.style.backgroundColor = new StyleColor(Color.gray);
        }
    }
}
