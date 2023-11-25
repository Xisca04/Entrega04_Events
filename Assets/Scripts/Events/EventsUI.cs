using UnityEngine;
using TMPro;

public class EventsUI : MonoBehaviour
{
    #region VARIABLES

    [SerializeField] private TextMeshProUGUI distanceText;
    private string defaultText = "Distance to Enemy";

    #endregion

    private void Awake()
    {
        // Call to activate the UI events
        InitializeText();
        OnEnableUIEvents();
    }

    private void InitializeText()
    {
        distanceText.text = defaultText;
    }

    private void UpdateText()
    {
        float distance = EventsPlayerController.Instance.DistanceToEnemy();
        distanceText.text = distance.ToString("F2");
    }

    public void OnEnableUIEvents() // Subscribing functions to events
    {
        EventsGameManager.OnEnterKeyPressed += UpdateText;
        EventsGameManager.OnEscapeKeyPressed += InitializeText;
    }
}
