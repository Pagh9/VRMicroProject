using UnityEngine;

public class BoxMovement : MonoBehaviour
{

    public int MovementSpeed;
    public float RotationSpeed;
    public Transform targetPoint;
    
    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveTowardsTarget()
    {
        transform.position = Vector3.MoveTowards(
            transform.position,
            targetPoint.position,
            MovementSpeed * Time.deltaTime
            );

    }
}
