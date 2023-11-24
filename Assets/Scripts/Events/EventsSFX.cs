using UnityEngine;

public class EventsSFX : MonoBehaviour
{
    #region VARIABLES

    [SerializeField] private ParticleSystem particleSystem;

    #endregion

    private void Awake()
    {
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

    public void OnEnableSFXEvents()
    {
        EventsGameManager.OnEnterKeyPressed += StartParticleSystem;
        EventsGameManager.OnEscapeKeyPressed += StopParticleSystem;
    }
}
