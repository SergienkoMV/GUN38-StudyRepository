using UnityEngine;
using UnityEngine.InputSystem;
using Zenject;

public class GameInstaller : MonoInstaller
{
    private Controls _inputActions;

    [SerializeField]
    private CellManager _cellManager;

    [SerializeField]
    private SceneController _sceneController;

    [SerializeField]
    private SOCellPaletteSettings _cellPaletteSettings;

    public override void InstallBindings()
    {
        _inputActions = new Controls();
        _inputActions.Game.Enable();
        Container.BindInstance(_inputActions.Game).AsSingle();
        Container.BindInstance(_cellManager).AsSingle();
        Container.BindInstance(_sceneController).AsSingle();
        Container.BindInstance(_cellPaletteSettings).AsSingle();

        _cellManager.OnCellClicked += CellManagerOnCellClicked;
    }

    private void CellManagerOnCellClicked(Cell cell)
    {
        cell.SetSelect(_cellPaletteSettings.Selected);
    }

    //private void Awake()
    //{

    //    _inputActions.Game.Restart.started += Restart_performed;
    //    _inputActions.Game.Restart.performed += Restart_performed;
    //    _inputActions.Game.Restart.canceled += Restart_performed;
    //}

    //private void Restart_performed(InputAction.CallbackContext obj)
    //{

    //}

    private void OnEnable()
    {
        _inputActions.Game.Enable();
    }

    private void OnDisable()
    {
        _inputActions.Game.Disable();
    }

    private void OnDestroy()
    {
        //_inputActions.Game.Restart.started -= Restart_performed;
        //_inputActions.Game.Restart.performed -= Restart_performed;
        //_inputActions.Game.Restart.canceled -= Restart_performed;
        _inputActions.Dispose();
    }
}
