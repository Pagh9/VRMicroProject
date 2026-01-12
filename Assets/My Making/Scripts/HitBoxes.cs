using UnityEngine;

public class HitBoxes : MonoBehaviour
{
    // Tells the raycast which objects can hit Unity physics layers,
    public LayerMask layer;

    // stores the last frame of the saber position to estimate swing direction
    public Vector3 previousPos;



    void Update()
    {
        //Debug.DrawRay(transform.position, transform.up * 10000f, Color.red);

        // shoots a physics raycast out every frame from the saber. Only hits objects in layer.
        RaycastHit hit; 
        if (Physics.Raycast(transform.position, transform.up, out hit, 1, layer))
        {
            // this code is the logic for the saber swing, if the angle is less than 130, you destory the box.
            if (Vector3.Angle(transform.position - previousPos, hit.transform.up) < 130)
            {
                Destroy(hit.transform.gameObject);
            }
        }
        previousPos = transform.position;
    }
}
