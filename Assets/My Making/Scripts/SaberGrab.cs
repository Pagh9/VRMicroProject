using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SaberGrab : MonoBehaviour
{

    public Color hoverColor = Color.cyan;
    public Color originalColor;
    private MeshRenderer rend;

    public bool isLeftSaber;
    public bool isHeld;
    public GameManager gameManager;


    void Awake()
    {
        rend = GetComponent<MeshRenderer>();
        rend.material.color = originalColor;
    }

    public void OnGrab()
    {
        gameManager.SaberPickedUp(isLeftSaber);
        isHeld = true;
        rend.material.color = originalColor;
    }

    public void OnRelease()
    {
        gameManager.SaberReleased(isLeftSaber);
        isHeld = false;
    }

  

    public void OnHoverEnter()
    {
        if (!isHeld)
        {
            rend.material.color = hoverColor;
            
        }
        

    }

    public void OnHoverExit()
    {
        if (!isHeld)
        {
            rend.material.color = originalColor;
        }
       
    }
}
