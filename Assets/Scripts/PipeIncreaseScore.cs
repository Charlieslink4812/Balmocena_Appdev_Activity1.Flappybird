using UnityEngine;

// Fixed: Changed 'Monobehaviour' to 'MonoBehaviour'
public class PipeIncreaseScore : MonoBehaviour 
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Note: Ensure your Player object has the tag "Player" 
        // Tags are also case-sensitive!
        if (collision.gameObject.CompareTag("Player"))
        {
            Score.instance.UpdateScore();
        }
    }
}