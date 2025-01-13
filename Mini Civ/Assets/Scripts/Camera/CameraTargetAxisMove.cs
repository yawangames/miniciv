using UnityEngine;
using UnityEngine.Events;

public class CameraTargetAxisMove : MonoBehaviour
{
    public Transform Target;
    public float moveSpeed;

    public Unselect unselect;

    bool movedLastFrame;

    void Update()
    {
        if (Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0)
        {
            if(!movedLastFrame)
                unselect.DoUnselect();  

            movedLastFrame = true;
            AxisMove();
        }

        else
            movedLastFrame = false;
    }

    void AxisMove()
    {
        float speedX = Input.GetAxis("Horizontal") * moveSpeed;
        float speedZ = Input.GetAxis("Vertical") * moveSpeed;

        Target.Translate(speedX, 0, speedZ);
    }
}
