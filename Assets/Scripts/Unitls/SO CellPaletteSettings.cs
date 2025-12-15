using UnityEngine;

[CreateAssetMenu(menuName = "Netologia/Scriptables/CellPaletteSettings", fileName = "CellPaletteSettings", order = 103)]

public class SOCellPaletteSettings : ScriptableObject
{
    [field: SerializeField, Space(10f)]
    [field: Tooltip("Поле под выбранным юнитом")]
    public Material Selected { get; private set; }

    [field: SerializeField]
    [field: Tooltip("Поле в которое можно переместить юнита")]
    public Material Movable { get; private set; }

    [field: SerializeField]
    [field: Tooltip("Поле в котором можно атаковать вражеского юнита")]
    public Material Usable { get; private set; }

    [field: SerializeField]
    [field: Tooltip("Поле в котором можно атаковать вражеского юнита и переместится")]
    public Material MoveAndUse { get; private set; }
}
