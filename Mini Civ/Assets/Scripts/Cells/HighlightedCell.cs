using UnityEngine;

public class HighlightedCell : MonoBehaviour
{
    public Cell highlightedCell;

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

    void HighlightCell(Cell cell)
    {
        transform.position = cell.transform.position;
    }

    void StopHighlight()
    {
        transform.position = Vector3.zero;

    }
}
