using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour {
    public Button Play;

    void Start()
    {
        Button btn = Play.GetComponent<Button>();
        btn.onClick.AddListener(OnMouseDown);
    }

    void OnMouseDown() {
        SceneManager.LoadScene("game");
        Debug.Log("You clicked it goof");
    }
}