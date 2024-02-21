using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private StatList _statList;
    [SerializeField] private HealthPanel _healthPanel;
    private void Awake()
    {
        ClickSelectController.OnSelectedEntityChanged += HandleSelectedEntityChanged;

        HandleSelectedEntityChanged(ClickSelectController.SelectedEntity);
    }

    private void OnDestroy()
    {
        ClickSelectController.OnSelectedEntityChanged -= HandleSelectedEntityChanged;
    }

    private void HandleSelectedEntityChanged(Entity entity)
    {
        if (_statList != null) ;
        //_statList.Bind(entity?.Stats);

        if (_healthPanel != null) ;
            _healthPanel.Bind(entity);
    }
}
