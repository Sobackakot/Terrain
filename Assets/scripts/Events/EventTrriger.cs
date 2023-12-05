 
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class EventTrriger : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    

    [SerializeField] private Material myMaterial;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            myMaterial.color = Color.red;
        }  
    }  
    public void OnPointerEnter(PointerEventData eventData)
    {
        myMaterial.color = Color.yellow;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        myMaterial.color = Color.green;
    }
}
