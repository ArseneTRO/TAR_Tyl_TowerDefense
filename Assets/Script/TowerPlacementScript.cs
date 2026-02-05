using UnityEngine;

public class TowerPlacementScript : MonoBehaviour
{
    public GameObject TowerPrefab;
    public GameObject Myself;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        var temp = Instantiate(TowerPrefab);
        temp.transform.position = transform.position;
        Myself.SetActive(false);
    }
}
