using UnityEngine;
using UnityEngine.InputSystem;
using Zenject;

public class GameInstaller : MonoInstaller
{
    private Controls _controls;

    [SerializeField]
    private CellManager _cellManager;

    [SerializeField]
    private SceneController _sceneController;

    [SerializeField]
    private SOCellPaletteSettings _cellPaletteSettings;

    public override void InstallBindings()
    {
        _controls = new Controls();
        _controls.Game.Enable();
        Container.BindInstance(_controls).AsSingle();
        //Container.BindInstance(_controls.Game).AsSingle(); //непонятно, как обращаться к такому значению в контейнере!? Попытался задать ID, но по ID тоже не получается получить значение через Inject
        Container.BindInstance(_cellManager).AsSingle();
        Container.BindInstance(_sceneController).AsSingle();
        Container.BindInstance(_cellPaletteSettings).AsSingle();

        _cellManager.OnCellClicked += CellManagerOnOnCellClicked;
    }

    private void CellManagerOnOnCellClicked(Cell cell)
    {
        cell.SetSelect(_cellPaletteSettings.Selected);
    }

    private void Awake()
    {

        //_controls.Game.Restart.started += OnRestartPerformed;
        //_controls.Game.Restart.performed += OnRestartPerformed;
        //_controls.Game.Restart.canceled += OnRestartPerformed;
    }

    private void OnRestartPerformed(InputAction.CallbackContext obj)
    {
        //InputManager.On
        print("test");
    }

    private void OnEnable()
    {
        _controls.Game.Enable();
    }

    private void OnDisable()
    {
        _controls.Game.Disable();
    }

    private void OnDestroy()
    {
        //_controls.Game.Restart.started -= OnRestartPerformed;
        //_controls.Game.Restart.performed -= OnRestartPerformed;
        //_controls.Game.Restart.canceled -= OnRestartPerformed;
        _controls.Dispose();
    }
}
