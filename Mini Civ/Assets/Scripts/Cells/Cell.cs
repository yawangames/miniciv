using UnityEngine;
using UnityEngine.UIElements;

public class Cell : MonoBehaviour
{

    public Neighborhood CurrentNeighborhood;

    public void AddNeighborhood(Neighborhood neighborhood)
    {
        CurrentNeighborhood = neighborhood;
    }

    public bool Buildable()
    {
        if(CurrentNeighborhood != null)
            return false;

        return true;
    }
}
