using UnityEngine;
using UnityEngine.UI;

public class DisplayScriptableObject : MonoBehaviour
{
    public Creature creature;
    public Image champPicture;

    private void Start()
    {
        champPicture.sprite = creature.champPicture;
    }

    public void OnMouseDown()
    {
        // Implement drag functionality
    }

    public void OnMouseUp()
    {
        // Implement drop functionality
    }
}