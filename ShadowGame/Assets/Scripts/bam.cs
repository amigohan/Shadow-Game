using UnityEngine;
using UnityEngine.UI;

public class GörünümKapatma : MonoBehaviour
{
    [SerializeField] private Image görünümImage;

    void Start()
    {
        // Görünümü kapat
        if (görünümImage != null)
        {
            görünümImage.enabled = false;
        }
    }
}
