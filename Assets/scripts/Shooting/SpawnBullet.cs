 
using UnityEngine;
using UnityEngine.EventSystems;

public class SpawnBullet : MonoBehaviour 
{
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private GameObject prefabBullet;


    public void Update()
    {
        LeftMouseClick();
    }

    public void LeftMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(prefabBullet, spawnPoint.position, transform.rotation);
        }
    }
}
