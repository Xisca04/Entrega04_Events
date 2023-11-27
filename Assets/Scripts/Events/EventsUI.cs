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
        InitializeText();
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

    private void OnEnable() // Subscribing functions to events and activate the UI events
    {
        EventsGameManager.OnEnterKeyPressed += UpdateText;
        EventsGameManager.OnEscapeKeyPressed += InitializeText;
    }

    private void OnDisable() // Unsuscrib functions to events and deactivate the UI events
    {
        EventsGameManager.OnEnterKeyPressed -= UpdateText;
        EventsGameManager.OnEscapeKeyPressed -= InitializeText;
    }
}
