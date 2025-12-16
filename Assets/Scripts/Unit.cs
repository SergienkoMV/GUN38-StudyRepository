using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class Unit : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    [SerializeField]
    private Cell _carrentCell;

    private void Awake()
    {
        var position = new Vector3(_carrentCell.transform.position.x, _carrentCell.transform.position.y + 2, _carrentCell.transform.position.z);
        transform.position = position;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //В реализации всех интерфейсов необходимо прокидывать вызов в клетку, на которой стоит юнит
        //_carrentCell.OnPointerClickEvent(_carrentCell);
       
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        //В реализации всех интерфейсов необходимо прокидывать вызов в клетку, на которой стоит юнит
        throw new System.NotImplementedException();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //В реализации всех интерфейсов необходимо прокидывать вызов в клетку, на которой стоит юнит
        throw new System.NotImplementedException();
    }

    public void Move(Cell cell)
    {
        // перемещает юнита с равномерной скоростью на указанную клетку и запоминает её

        //По окончанию движения нужно вызывать событие OnMoveEndCallback

    }
}
