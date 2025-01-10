using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CameraFollowTarget : MonoBehaviour
{
    public Transform target;
    public float smooth = 0.01f;
    public Vector3 defaultOffset;


    void Update()
    {
        Vector3 targetPosition = target.position + defaultOffset;
        transform.position = Vector3.Lerp(transform.position,    targetPosition, Time.deltaTime * smooth);
    }
}
