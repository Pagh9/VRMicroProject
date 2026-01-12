using UnityEngine;
using UnityEngine.UIElements;

public class BoxMovement : MonoBehaviour
{

    public int MovementSpeed;

    // Planned features, not enough time
    public float RotationSpeed;
    public Transform targetPoint;

    
    private void Start()
    {
        //Picks a rotation at random
        int angle = Random.Range(0, 4);
        switch (angle)

        {
            case 0: angle = 0; break;
            case 1: angle = 90; break;
            case 2: angle = 180; break;
            case 3: angle = 270; break;

        }
        transform.rotation = Quaternion.Euler(angle, -90, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //Clean up if player dont destroy the object themselfes.
        if (gameObject.transform.position.z <= -20)
        {
            Destroy(gameObject);
        }
        MoveTowardsTarget();

    }

    public void MoveTowardsTarget()

    {
        //Movement logic
        transform.Translate(Vector3.left * MovementSpeed * Time.deltaTime);
       



    }
}
