using UnityEngine;

public class SpawningBoxes : MonoBehaviour
{
    public GameObject RedBox;
    public GameObject BlueBox;

    public GameObject SpawnBox;

    public int SpawnCount;
 


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BoxSpawner();
    }

    public void BoxSpawner()
    {
        if(SpawnCount <= 10)
        {
            Instantiate(RedBox, transform.position, Quaternion.identity);
            SpawnCount++;
        }
    }
}
