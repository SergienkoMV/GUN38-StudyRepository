using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellManager : MonoBehaviour
{
    private Dictionary<CellNeibour, Cell> _neighbours;
    private Cell[] _cells;

    public event Action<Cell> OnCellClicked;

    void Awake()
    {
        _cells = FindObjectsOfType<Cell>();
        //_neighbours = new Dictionary<CellNeibour, Cell>(_cells.Length * 8);
        //var positions = Array.ConvertAll(_cells, t => t.transform.position);
        //var distance = 0f;
        for (int i = 0, iMax = _cells.Length; i < iMax; i++)
        {
            _cells[i].OnPointerClickEvent += OnCellClicked;
#if UNITY_EDITOR
            //_cells[i].OnPointerClickEvent += DebugOnPointerClick;
#endif
            //for (int j = 0, jMax = _cells.Length; j < jMax; j++)
            //{
            //    if (i == j) continue;
            //    var source = positions[i];
            //    var destenation = positions[j];

            //    var forvard = destenation.z.CompareTo(source.z);
            //    var right = destenation.x.CompareTo(source.x);
            //    var type = (forvard, right) switch
            //    {
            //        (1, 1) => NeighbourType.rtop,
            //        (1, 0) => NeighbourType.top,
            //        (1, -1) => NeighbourType.ltop,
            //        (0, 1) => NeighbourType.right,
            //        (0, -1) => NeighbourType.left,
            //        (-1, 1) => NeighbourType.rbottom,
            //        (-1, 0) => NeighbourType.bottom,
            //        (-1, -1) => NeighbourType.lbottom,
            //        _ => default
            //    };
            //    var key = new CellNeibour(type, _cells[i]);
            //    var check = _neighbours.TryGetValue(key, out var cell) ? Vector3.Distance(source, cell.transform.position) : 0;
            //}
        }
    }
}
