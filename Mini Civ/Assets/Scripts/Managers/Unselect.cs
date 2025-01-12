using UnityEngine;

public class Unselect : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            var actions = GetComponents<IUnselectAction>();

            foreach (var action in actions)
            {
                action.Unselect();
            }

        }

    }
}
