using UnityEngine;

public class Shooter : MonoBehaviour
{
    public CircleCollider2D redZone;
    public Bullet bullet;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter2D(Collider2D other)  //Quand il rentre dans la zone de détection, le trigger crée pour l'occasion
    {
        print("TriggerEnter");
        if (other.tag == "ennemie") //s'il as le tag "ennemie"
        {
            print("Y'a un ennemie");
            var Temp = Instantiate(bullet);
            Temp.transform.position = transform.position;
            bullet.targetEnemy = other.GetComponent<Transform>();  //Récupérer son Transform et le give à la bullet comme cible

        }
    }

}
