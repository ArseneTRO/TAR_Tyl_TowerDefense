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

    /*var temp = Instantiate(Bullet);
    temp.transform.position = transform.position;*/
    
    void OnTriggerEnter(Collider other)  //Quand il rentre dans la zone de détection, le trigger crée pour l'occasion
    {
        if (other.tag == "ennemie") //s'il as le tag "ennemie"
        {
            print("Y'a un ennemie");
            /*bullet.targetEnemy = other.GetComponent<Transform>();  //Récupérer son Transform et le give à la bullet comme cible*/

        }
    }

}
