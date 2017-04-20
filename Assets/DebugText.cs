using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugText : HoloToolkit.Unity.Singleton<DebugText> {

    private List<string> DebugLogStrings;

    private Text Text;

    public int MaxNumMessages = 16;

    private bool textNeedsUpdate = false;

	// Use this for initialization
	void Start () {
        DebugLogStrings = new List<string>();
        Text = this.GetComponent<Text>();

        Clear();
    }
	
	// Update is called once per frame
	void Update () {
		if (textNeedsUpdate)
        {
            UpdateText();
            textNeedsUpdate = false;
        }
	}

    public void Clear()
    {
        DebugLogStrings.Clear();

        textNeedsUpdate = true;
    }

    public void AddMessage(string msg)
    {
        DebugLogStrings.Add(msg);

        textNeedsUpdate = true;
    }

    void UpdateText()
    {
        int endIdx = DebugLogStrings.Count;
        int startIdx = endIdx - MaxNumMessages;
        if (startIdx < 0)
        {
            startIdx = 0;
        }

        string outputString = "";

        for (int i = startIdx; i < endIdx; i++)
        {
            outputString += DebugLogStrings[i] + "\n";
        }

        this.Text.text = outputString;
    }
}
