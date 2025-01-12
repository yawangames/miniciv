using System.Linq;
using UnityEngine;

public class CellSelect : MonoBehaviour
{
    public void Select()
    {
        BuildingManager.Instance.SelectCell(GetComponent<Cell>());

        var actions = GetComponents<ICellSelect>();

        foreach (var action in actions)
        {
            action.OnCellSelect();
        }
    }
}
