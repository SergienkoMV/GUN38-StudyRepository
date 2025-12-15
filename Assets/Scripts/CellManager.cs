using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellManager : MonoBehaviour
{
    private Cell[] _cells;
    
    void Start()
    {
        _cells = FindObjectsOfType<Cell>();
    }

    void Update()
    {
        
    }

    public event Action<Cell> OnCellClicked;

    //public void OnCellClicked(Cell cell)
    //{

    //}
}
