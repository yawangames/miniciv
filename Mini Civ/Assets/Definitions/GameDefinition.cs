using UnityEngine;

[CreateAssetMenu(fileName = "GameDefinition", menuName = "Scriptable Objects/GameDefinition")]
public class GameDefinition : ScriptableObject
{
    public Vector2 gridSize;
    public float cellSize = 1f;
}
