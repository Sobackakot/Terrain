using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListenerEvent : MonoBehaviour
{
    [SerializeField] private MeshRenderer m_Renderer;
    [SerializeField] private Material materialSphere;
    public void ChangeColorClick()
    {
        Debug.Log("ChangeColorClick");
        materialSphere.color = Color.blue;
    }
    public void ReturnColorClick()
    {
        Debug.Log("ReturnColorClick");
        materialSphere.color = Color.green;
    }
    public void TurnOfMesh()
    {
        m_Renderer.enabled = false;
    }
    public void TurnOnMesh()
    {
        m_Renderer.enabled = true;
    }
}
