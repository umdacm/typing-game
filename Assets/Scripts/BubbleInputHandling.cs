using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleInputHandling : MonoBehaviour {
    // This is public only so we can observe it from the editor
    // This probably shouldn't be edited from the editor
    public string textSoFar = "";
    public Color typedTextColor;

    private string text;
    
	// Use this for initialization
	void Start () {
        text = GetComponentInChildren<TextMesh>().text;
	}
	
	// Update is called once per frame
	void Update () {
        HandleInputs();
	}

    void HandleInputs()
    {
        foreach (char c in Input.inputString)
        {
            // We can't edit c because it's part of the foreach loop
            // so we have this "real_char" variable so we can modify it if needed
            char real_char = c;

            // If shift is pressed
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
            {
                real_char = char.ToUpper(real_char);
            }

            // If the typed character is the next character in the our text
            // than we add it to textSoFar and check if it's done
            if (real_char == text[textSoFar.Length])
            {
                textSoFar += real_char;
                string notTyped = text.Substring(textSoFar.Length);
                ChangeText(textSoFar, notTyped);
                if (TextIsCompleted())
                {
                    TextComplete();
                }
            }
            // If we mistype something than we reset it
            else
            {
                textSoFar = "";
                ChangeText("", text);
            }

        }
    }

    void ChangeText(string typedText, string notTypedText)
    {
        string htmlColor = ColorUtility.ToHtmlStringRGBA(typedTextColor);
        string newText = "";
        // Format the rich text for the colored text
        newText += "<color=#" + htmlColor + ">" + typedText + "</color>" + notTypedText;
        GetComponentInChildren<TextMesh>().text = newText;
    }

    void TextComplete()
    {
        // This is where we would put things that happen when a bubble is typed correctly
        Destroy(gameObject);
    }

    bool TextIsCompleted()
    {
        return textSoFar.Equals(text);
    }
}
