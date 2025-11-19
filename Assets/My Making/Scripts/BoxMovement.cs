using UnityEngine;

public class BoxMovement : MonoBehaviour
{

    public int MovementSpeed;
    public float RotationSpeed;
    public Transform targetPoint;
    
    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.z <= -20)
        {
            Destroy(gameObject);
        }
        MoveTowardsTarget();

    }

    public void MoveTowardsTarget()
    {
        transform.Translate(Vector3.back * MovementSpeed * Time.deltaTime); 


    }
}
