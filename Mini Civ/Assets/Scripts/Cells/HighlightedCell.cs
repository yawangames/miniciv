using UnityEngine;

public class HighlightedCell : MonoBehaviour
{
    public Cell highlightedCell;

    public static HighlightedCell Instance;

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            SelectCell();
    }

    void FixedUpdate()
    {        
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100))
        {
            if (hit.transform.parent.GetComponent<Cell>())
                HighlightCell(hit.transform.parent.GetComponent<Cell>());
        }
        else
            StopHighlight();
    }

    void SelectCell()
    {
        if (BuildingManager.Instance.selectedCell != null) return;

        if (highlightedCell == null) return;

        highlightedCell.GetComponent<CellSelect>().Select();
    }

    void HighlightCell(Cell cell)
    {
        highlightedCell = cell;
        transform.position = cell.transform.position;
    }

    void StopHighlight()
    {
        highlightedCell = null;
        transform.position = Vector3.zero;

    }
}
