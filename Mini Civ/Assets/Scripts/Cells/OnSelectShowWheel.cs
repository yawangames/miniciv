using UnityEngine;

public class OnSelectShowWheel : MonoBehaviour, ICellSelect
{
    public WheelOptionList emptyOptions;
    private WheelOptionList options;

    private void Start()
    {
        options = emptyOptions;    }

    public void OnCellSelect()
    {
        WheelManager.Instance.OpenWheel(options);
    }

    public void ResetOptionsToEmpty()
    {
        options = emptyOptions;
    }

    public void ChangeOptions(WheelOptionList _options)
    {
        options = _options;
    }
}
