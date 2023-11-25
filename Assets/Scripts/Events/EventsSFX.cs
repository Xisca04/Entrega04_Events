using UnityEngine;

public class EventsSFX : MonoBehaviour
{
    #region VARIABLES

    [SerializeField] private ParticleSystem particleSystem;

    #endregion

    private void Awake()
    {
        // Call to activate the SFX events
        StopParticleSystem();
        OnEnableSFXEvents();
    }

    private void StartParticleSystem()
    {
        particleSystem.Play();
    }
    
    private void StopParticleSystem()
    {
        particleSystem.Stop();
    }

    public void OnEnableSFXEvents() // Subscribing functions to the events
    {
        EventsGameManager.OnEnterKeyPressed += StartParticleSystem;
        EventsGameManager.OnEscapeKeyPressed += StopParticleSystem;
    }
}
