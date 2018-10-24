using UnityEngine;
using UnityEngine.UI;

public class OptionsButton : MonoBehaviour
{
    public Button Option;

    void Start()
    {
        Button btn = Option.GetComponent<Button>();
        btn.onClick.AddListener(OnMouseDown);
    }

    void OnMouseDown()
    {
        Debug.Log("You clicked Options");
    }
}