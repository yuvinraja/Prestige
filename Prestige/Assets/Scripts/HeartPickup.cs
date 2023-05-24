using UnityEngine;
using UnityEngine.SceneManagement;

public class HeartPickup : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Destroy the heart game object
            Destroy(gameObject);

            // Teleport the player to the "Healthbar" scene
            SceneManager.LoadScene("Healthbar", LoadSceneMode.Single);
            Debug.Log("Teleport");
        }
    }
}
