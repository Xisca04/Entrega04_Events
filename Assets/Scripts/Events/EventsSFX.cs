using UnityEngine;

public class EventsSFX : MonoBehaviour
{
    #region VARIABLES

    [SerializeField] private ParticleSystem particleSystem;

    #endregion

    private void Awake()
    {
        StopParticleSystem();
    }

    private void StartParticleSystem()
    {
        particleSystem.Play();
    }
    
    private void StopParticleSystem()
    {
        particleSystem.Stop();
    }

    private void OnEnable() // Subscribing functions to the events and activate the SFX events
    {
        EventsGameManager.OnEnterKeyPressed += StartParticleSystem;
        EventsGameManager.OnEscapeKeyPressed += StopParticleSystem;
    }

    private void OnDisable() // Unsubscrib functions to the events and deactivate the SFX events
    {
        EventsGameManager.OnEnterKeyPressed -= StartParticleSystem;
        EventsGameManager.OnEscapeKeyPressed -= StopParticleSystem;
    }
}
