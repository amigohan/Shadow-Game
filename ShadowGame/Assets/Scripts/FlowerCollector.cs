// ObjectInteractionScript.cs
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectInteractionScript : MonoBehaviour
{
    private bool objectTouched = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("InteractableObject"))
        {
            // Object touched, make it disappear
            other.gameObject.SetActive(false);
            objectTouched = true;
        }
    }

    private void Update()
    {
        // Check if the user presses a key to transition to the OtherScene
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Debug log to check the value of objectTouched before scene transition
            Debug.Log("Object Touched: " + objectTouched);

            // Pass the objectTouched variable to the OtherScene
            PlayerPrefs.SetInt("ObjectTouched", objectTouched ? 1 : 0);

            // Load the OtherScene
        }
    }
}
