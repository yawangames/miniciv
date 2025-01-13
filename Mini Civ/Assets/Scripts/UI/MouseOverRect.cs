using UnityEngine;

public class MouseOverRect : MonoBehaviour
{

    private void OnPointerEnter()
    {
        Debug.Log("mouse is over");
    }

    private void OnMouseExit()
    {
        Debug.Log("mouse is out");
    }
}
