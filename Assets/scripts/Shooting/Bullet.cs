using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;  

    private float speed = 10.0f;


    public void Update()
    {
        MoveBullet();
    }

    public void MoveBullet()
    {
        bulletPrefab.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        StartCoroutine(DestroyBulletCoroutine());
    }

    public IEnumerator DestroyBulletCoroutine()
    {
        yield return new WaitForSeconds(10);
        Destroy(bulletPrefab);
    }

    public void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
