using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Zenject;

public class InputManager : MonoBehaviour
{
    //в показанном примере, проме Inject через Construct, так же были объявлены переменные _controls и _sceneController, при этом _controls с типом Controls.GameActions. Почему?
    [Inject]
    private Controls _controls;
 
    [Inject]
    private SceneController _sceneController;

    //можно было реализовать так:
    //[Inject]
    //private void Construct(SceneController sceneController, Controls controls)
    //{
    //    _sceneController = sceneController;
    //    _controls = controls;
    //}


    //private Controls.GameActions _inputActions;

    private Coroutine _restartCoroutine;

    [SerializeField]
    private GameObject _restartUI;
    [SerializeField]
    private Image _restartFill;
    [SerializeField, Range(0.1f, 1f)]
    private float _restartPushInSec = 0.25f;

    private void Start()
    {
        _controls.Game.Restart.performed += OnRestartPerformed;
        _controls.Game.Restart.canceled += OnRestartCancel;
        _restartFill.fillAmount = 0f;
        _restartUI.SetActive(false);
    }

    private void OnRestartPerformed(InputAction.CallbackContext obj)
    {
        _restartUI.SetActive(true);
        _restartCoroutine = StartCoroutine(Restarter());
        
    }

    private void OnRestartCancel(InputAction.CallbackContext obj)
    {
        _restartUI.SetActive(false);
        StopCoroutine(_restartCoroutine);
        _restartFill.fillAmount = 0f;
    }

    // предположительно, при нажатии Escape запускается и выполняется карутина, которая заполняет шкалу
    // при отпускании, корутина останавливается и выключается UI
    private IEnumerator Restarter()
    {
        while (_restartFill.fillAmount < 1f)
        {
            _restartFill.fillAmount += _restartPushInSec * Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
        _sceneController.OpenGameScene();
    }

    private void OnDestroy()
    {
        _controls.Game.Restart.performed -= OnRestartPerformed;
        _controls.Game.Restart.canceled -= OnRestartCancel;
    }
}
