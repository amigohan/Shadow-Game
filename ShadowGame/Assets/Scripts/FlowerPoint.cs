using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ImageVisibilityScript : MonoBehaviour
{
    public GameObject uiElement;

    private void Start()
    {
        // Check if the object was touched in the MainScene
        int objectTouched = PlayerPrefs.GetInt("ObjectTouched", 0);

        // Debug log to check the value of objectTouched when entering OtherScene
        Debug.Log("Object Touched in OtherScene: " + objectTouched);

        // If the object was touched, make the UI element visible
        if (objectTouched == 1)
        {
            uiElement.SetActive(true);
        }
        else
        {
            uiElement.SetActive(false);
        }
    }
}