using UnityEngine;

public class CameraTargetAxisMove : MonoBehaviour
{
    public Transform Target;
    public float moveSpeed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0)
            AxisMove();
    }

    void AxisMove()
    {
        float speedX = Input.GetAxis("Horizontal") * moveSpeed;
        float speedZ = Input.GetAxis("Vertical") * moveSpeed;

        Target.Translate(speedX, 0, speedZ);
    }
}
