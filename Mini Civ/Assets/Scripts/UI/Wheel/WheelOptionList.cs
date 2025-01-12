using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "WheelOptionList", menuName = "Scriptable Objects/Wheel Option List")]
public class WheelOptionList : ScriptableObject
{
    public List<WheelOption> options;
}
