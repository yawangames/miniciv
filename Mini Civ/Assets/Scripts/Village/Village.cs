using NUnit.Framework;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Village : MonoBehaviour
{
    public Neighborhood defaultNeighborhood;

    public List<Neighborhood> neighborhoods;

    [SerializeField] private UnityEvent onVillageBuild;

    public void OnBuildVillage()
    {
        onVillageBuild.Invoke();

        AddFirstNeighborhood();
    }

    void AddFirstNeighborhood()
    {
        Cell selectedCell = BuildingManager.Instance.selectedCell;
        AddNeighborhood(selectedCell, defaultNeighborhood);
    }

    public void AddNeighborhood(Cell cell, Neighborhood neighborhood)
    {
        var newNeigh = Instantiate(neighborhood.gameObject, cell.transform.position, Quaternion.identity, transform);
        Neighborhood thisNeigh = newNeigh.GetComponent<Neighborhood>();

        neighborhoods.Add(thisNeigh);
        thisNeigh.associatedVillage = this;
    }
}
