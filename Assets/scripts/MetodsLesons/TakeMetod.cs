 
using UnityEngine;

public class TakeMetod : MonoBehaviour
{
    public Material cube; 

    public void Start()
    {
        TakeData(Color.yellow);
    }
    public void OnEnable()
    {
        ReturnMetod.OnColorChange += TakeData;
    }
    public void OnDisable()
    {
        ReturnMetod.OnColorChange -= TakeData;
    }
     
    public void TakeData(Color color)
    {
        cube.color = color;
    }
}
