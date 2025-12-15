using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class Cell : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        //В реализации OnPointerEnter меш Focus должен включаться
        throw new System.NotImplementedException();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        //В реализации OnPointerClick нужно вызывать событие OnPointerClickEvent и передавать в качестве аргумента саму клетку
        //OnPointerClickEvent.Invoke(eventData);
        throw new System.NotImplementedException();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //В реализации OnPointerExit меш Focus должен выключаться
        throw new System.NotImplementedException();
    }

    public void SetSelect(Material material)
    {
        //включать меш Select и задавать материал, полученный в аргументе

    }

    public void ResetSelect()
    {
        //выключать меш Select
    }
}
