using UnityEngine;

public class ShortstuffRagdoll : MonoBehaviour
{
    // REFERENCES
    [SerializeField] private Rigidbody2D torso;
    [SerializeField] private Rigidbody2D[] bodyParts;

    // SETUP
    public void Activate(Vector2 initialVelocity, Vector2 explosionImpulse)
    {
        // Transfer the player's existing velocity
        foreach (Rigidbody2D part in bodyParts)
        {
            if (part != null)
            {
                part.linearVelocity = initialVelocity;
            }
        }

        // Apply the explosion force to the chest
        torso.AddForce(explosionImpulse, ForceMode2D.Impulse);
    }
    private void Start()
    {
        Activate(Vector2.zero, new Vector2(5f, 10f));
    }
}