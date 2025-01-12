
using UnityEngine;

public class UnselectUnselectCell : MonoBehaviour, IUnselectAction
{
    public void Unselect()
    {
        BuildingManager.Instance.UnselectCell();
    }
}