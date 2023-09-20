using UnityEngine;

public class SpawnPrefab : MonoBehaviour
{
    public GameObject championPrefab; // Reference to your "Champion" prefab

    void Start()
    {
        // Check if the championPrefab is assigned
        if (championPrefab != null)
        {
            // Spawn the "Champion" prefab at the world origin (0,0,0)
            Instantiate(championPrefab, Vector3.zero, Quaternion.identity);
        }
        else
        {
            Debug.LogError("Champion prefab not assigned in the Inspector.");
        }
    }
}
