using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIButtonController : MonoBehaviour
{
    public Canvas canvas; // UI'nin bulunduğu Canvas referansı

    private void Start()
    {
        if (canvas == null)
        {
            // Eğer Canvas referansı atanmamışsa, varsayılan olarak Canvas'i bul
            canvas = FindObjectOfType<Canvas>();
        }
    }

    public void CloseUIAndReloadScene()
    {
        if (canvas != null)
        {
            // Canvas'i kapat
            canvas.gameObject.SetActive(false);
        }

        // Şuanki sahneyi yeniden yükle
        SceneManager.LoadScene(1);
    }
}
