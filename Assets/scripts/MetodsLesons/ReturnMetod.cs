using System;
using UnityEngine;

public class ReturnMetod : MonoBehaviour
{   
    public static event Action<Color> OnColorChange;

    public Color color;

    public void OnTriggerEnter(Collider other)
    {
        color = ReturnData();
        OnColorChange.Invoke(color);
    }
    public void OnTriggerExit(Collider other)
    {
        color = ReturnNewData();
        OnColorChange.Invoke(color);
    }
    public Color ReturnData()
    {
      
        return color = Color.green;
    }
    public Color ReturnNewData()
    { 
        return color = Color.yellow;
    }
}
