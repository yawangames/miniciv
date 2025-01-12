using UnityEngine;

public class UnselectCloseWheel : MonoBehaviour, IUnselectAction
{    
    public void Unselect()
    {
        WheelManager.Instance.CloseWheel();
    }
}
