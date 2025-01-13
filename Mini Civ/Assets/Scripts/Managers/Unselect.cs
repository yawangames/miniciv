using UnityEngine;

public class Unselect : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            DoUnselect();
        }
    }

    public void DoUnselect()
    {
        var actions = GetComponents<IUnselectAction>();

        foreach (var action in actions)
            action.Unselect();
    }
}
