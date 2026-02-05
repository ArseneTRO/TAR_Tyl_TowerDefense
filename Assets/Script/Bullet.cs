using System.Collections;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Transform targetEnemy;
    public int dammage;
    public SpriteRenderer spriteRenderer;
    public float speed = 0.2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 dirToTarget = (targetEnemy.position - transform.position).normalized;

        transform.position += dirToTarget * speed;
    
        if (targetEnemy == null)
        {
            StartCoroutine(DestroyObject());
        }

    }
    
    IEnumerator DestroyObject()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
        
    }

}
