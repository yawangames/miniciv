using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;

public class CellSelect : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (IsMouseOverUi.Instance.IsPointerOverUIElement()) return;

        Select();
    }

    public void Select()
    {
        BuildingManager.Instance.SelectCell(transform.parent.GetComponent<Cell>());

        var actions = transform.parent.GetComponents<ICellSelect>();

        foreach (var action in actions)
        {
            action.OnCellSelect();
        }
    }



}
