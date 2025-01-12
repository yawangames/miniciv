using NUnit.Framework;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WheelManager : MonoBehaviour
{
    public static WheelManager Instance;

    public GameObject wheel;

    List<GameObject> currentOptions = new List<GameObject>();

    private void Awake()
    {
        Instance = this;
    }

    public void OpenWheel(WheelOptionList wheelOptions)
    {
        wheel.SetActive(true);

        CreateOptions(wheelOptions);

    }

    public void CloseWheel()
    {
        wheel.SetActive(false);
    }

    void CreateOptions(WheelOptionList wheelOptions)
    {
        CleanOptions();

        foreach (var option in wheelOptions.options)
        {
            AddOption(option);
        }
    }

    void AddOption(WheelOption option)
    {
        GameObject newOption = Instantiate(option.wheelOptionPrefab, Vector3.zero, Quaternion.identity);
        newOption.GetComponent<Transform>().SetParent(wheel.transform);
        newOption.transform.position = Vector3.zero;

        currentOptions.Add(newOption);
    }


    void CleanOptions()
    {
        foreach (var option in currentOptions) 
        {
            Destroy(option);
        }

        currentOptions.Clear();
    }
}
