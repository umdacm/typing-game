using UnityEngine;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour
{
    public Button Quit;

    void Start()
    {
        Button btn = Quit.GetComponent<Button>();
        btn.onClick.AddListener(OnMouseDown);
    }

    void OnMouseDown()
    {
        Application.Quit();
    }
}