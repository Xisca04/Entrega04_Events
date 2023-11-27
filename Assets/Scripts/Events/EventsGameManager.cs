using UnityEngine;

public class EventsGameManager : MonoBehaviour
{
    // HERE YOU WILL HAVE TO DECLARE AND INVOKE THE EVENTS

    public delegate void EventEnter(); // Delegate of OnEnterKeyPressed event
    public delegate void EventEscape(); // Delegate of OnEscapeKeyPressed event

    // Statement of the events
    public static event EventEnter OnEnterKeyPressed;
    public static event EventEscape OnEscapeKeyPressed;

    private void Update()
    {
        EnterKeyClicked();
        EscapeKeyClicked();
    }

    private void EnterKeyClicked()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (OnEnterKeyPressed != null)
            {
                OnEnterKeyPressed();
            }
        }
    }

    private void EscapeKeyClicked()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (OnEscapeKeyPressed != null)
            {
                OnEscapeKeyPressed();
            }
        }
    }
}
