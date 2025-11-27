using UnityEngine;

public class HitBoxes : MonoBehaviour
{
    public LayerMask layer;
    public Vector3 previousPos;



    void Update()
    {
        //Debug.DrawRay(transform.position, transform.up * 10000f, Color.red);
        RaycastHit hit; 
        if (Physics.Raycast(transform.position, transform.up, out hit, 1, layer))
        {
            if (Vector3.Angle(transform.position - previousPos, hit.transform.up) < 130)
            {
                Destroy(hit.transform.gameObject);
            }
        }
        previousPos = transform.position;
    }
}
