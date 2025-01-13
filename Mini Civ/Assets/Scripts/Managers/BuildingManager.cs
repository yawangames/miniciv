using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{    
    public static BuildingManager Instance;

    public Village village;

    public Cell selectedCell;
    public GameObject selectedFeedback;


    public List<Neighborhood> neighborhoods = new List<Neighborhood>();

    private void Awake()
    {
        Instance = this;
    }
    public void TryBuildVillage()
    {
        if (!selectedCell) return;

        if (!selectedCell.Buildable()) return;

        Village newVillage = Instantiate(village, selectedCell.transform.position, Quaternion.identity);
        newVillage.GetComponent<Village>().OnBuildVillage();
    }

    public void SelectCell(Cell cell)
    { 
        selectedCell = cell;
        selectedFeedback.SetActive(true);
        selectedFeedback.transform.position = cell.transform.position;
    }

    public void UnselectCell()
    {
        selectedCell = null;
        selectedFeedback.SetActive(false);
    }
}
