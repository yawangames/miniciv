using UnityEngine;

public class GridCreate : MonoBehaviour
{
    public GameObject cellObject;

    float offsetX;
    float offsetZ;

    private void Start()
    {
        CreateGrid();
    }


    void CreateGrid()
    {
        offsetX = GameManager.Instance.GameDefinition.cellSize *0.866f;
        offsetZ = GameManager.Instance.GameDefinition.cellSize *1.5f *.5f;

        Vector2 gridSize = GameManager.Instance.GameDefinition.gridSize;

        for (int i = 0; i < gridSize.x; i++)
        {
            for (int j = 0; j < gridSize.y; j++)
            {
                Vector2 coordinates = new Vector2(i, j);
                CreateCell(coordinates);
            }
        }
    }

    void CreateCell(Vector2 cellCoordinates)
    {
        float posX = cellCoordinates.x* offsetX;
        float posZ = cellCoordinates.y* offsetZ;
        if (cellCoordinates.y % 2 == 1)
            posX += offsetX * .5f;

        GameObject newCell = Instantiate(cellObject, transform);
        newCell.transform.position = new Vector3 (posX, 0,posZ);
    }
}
