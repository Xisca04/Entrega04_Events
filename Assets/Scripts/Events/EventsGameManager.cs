using UnityEngine;

public class EventsGameManager : MonoBehaviour
{
    // HERE YOU WILL HAVE TO DECLARE AND INVOKE THE EVENTS

    public delegate void Delegado1();
    public delegate void Delegado2();

    public static event Delegado1 OnEnterKeyPressed;
    public static event Delegado2 OnEscapeKeyPressed;

    private void Update()
    {

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
