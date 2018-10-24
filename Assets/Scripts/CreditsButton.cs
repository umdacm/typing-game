using UnityEngine;
using UnityEngine.UI;

public class CreditsButton : MonoBehaviour
{
    public Button Credit;

    void Start()
    {
        Button btn = Credit.GetComponent<Button>();
        btn.onClick.AddListener(OnMouseDown);
    }

    void OnMouseDown()
    {
        Debug.Log("You clicked Credits");
    }
}