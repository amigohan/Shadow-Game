using UnityEngine;
using TMPro;

public class ButtonScript : MonoBehaviour
{
    public GameObject uiElement;

    public void OnButtonPress()
    {
        PlayerPrefs.SetInt("ObjectTouched", false ? 1 : 0);
    }
}
