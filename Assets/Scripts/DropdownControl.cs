using UnityEngine;
using TMPro;


public class DropdownControl : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown dropdown;

    public void DropdownValueChanged(int index)
    {
        Debug.Log("Вы выбрали пункт номер: " + dropdown.options[index].text);
    }

    public void Start()
    {
        dropdown.onValueChanged.AddListener(DropdownValueChanged);
    }
}
