 
using UnityEngine;
using UnityEngine.Events; 

public class OnCollisionEvents  : MonoBehaviour
{
    [SerializeField] private UnityEvent OnTurnOfMesh;
    [SerializeField] private UnityEvent OnTurnOnMesh;

    [SerializeField] private Material materialCube; 

    public void OnCollisionEnter(Collision collision)
    {   
        if(collision.gameObject.tag == "Player")
        {
            materialCube.color = Color.red;
            OnTurnOfMesh.Invoke();
        } 
    }
    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            materialCube.color = Color.yellow;
            OnTurnOnMesh.Invoke();
        }
    }
    //public void OnTriggerEnter(Collider collider)
    //{
    //    if (collider.CompareTag("Player"))
    //    {
    //        Debug.Log("Enter");
    //    }
    //}
    //public void OnTriggerExit(Collider collider)
    //{
    //    if (collider.CompareTag("Player"))
    //    {
    //        Debug.Log("exit");
    //    }
    //}

} 

