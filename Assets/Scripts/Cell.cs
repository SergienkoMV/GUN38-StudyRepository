using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class Cell : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler, IPointerExitHandler
{
    [SerializeField]
    private MeshRenderer _focus;

    [SerializeField]
    private MeshRenderer _select;
    
    public Unit Unit { get; set; }

    public event Action<Cell> OnPointerClickEvent;

    public void SetSelect(Material material) => (_select.enabled, _select.material) = (true, material);
        //включать меш Select и задавать материал, полученный в аргументе

    public void ResetSelect()
    {
        //выключать меш Select
        _select.enabled = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //В реализации OnPointerEnter меш Focus должен включаться
        _focus.enabled = true;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        //В реализации OnPointerClick нужно вызывать событие OnPointerClickEvent и передавать в качестве аргумента саму клетку
        OnPointerClickEvent.Invoke(this); //OnPointerClickEvent - при клике на клетку инициируется данное событие с передачей в него данной клетки.
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //В реализации OnPointerExit меш Focus должен выключаться
        _focus.enabled = false;
    }


}
