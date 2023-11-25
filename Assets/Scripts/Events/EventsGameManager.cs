using UnityEngine;

public class EventsGameManager : MonoBehaviour
{
    // HERE YOU WILL HAVE TO DECLARE AND INVOKE THE EVENTS

    public delegate void EventHandler1();
    public delegate void EventHandler2();

    public static event EventHandler1 OnEnterKeyPressed;
    public static event EventHandler2 OnEscapeKeyPressed;

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
