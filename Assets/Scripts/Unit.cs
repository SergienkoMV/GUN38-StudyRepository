using UnityEngine;
using UnityEngine.EventSystems;

public class Unit : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        //В реализации всех интерфейсов необходимо прокидывать вызов в клетку, на которой стоит юнит
        throw new System.NotImplementedException();
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
