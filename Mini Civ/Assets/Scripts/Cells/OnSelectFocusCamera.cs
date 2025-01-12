using UnityEngine;

public class OnSelectFocusCamera : MonoBehaviour, ICellSelect
{
    public void OnCellSelect()
    {
        Camera.main.GetComponent<CameraFollowTarget>().target.transform.position = transform.position;
    }
}
