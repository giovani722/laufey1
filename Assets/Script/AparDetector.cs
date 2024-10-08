using UnityEngine;

public class AparDetector : MonoBehaviour
{
    private ParticleSystem fireParticle;
    private float drainAmount = 0.01f;

    private void Awake()
    {
        fireParticle = GetComponent<ParticleSystem>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("APAR"))
        {
            var main = fireParticle.main;
            main.startLifetimeMultiplier -= drainAmount;
        }
    }
}
