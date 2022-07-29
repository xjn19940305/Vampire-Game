using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score
{
    private static Score _instance { get; set; } = null;
    private static TextMeshProUGUI _textMeshProUGUI { get; set; }
    private int _value { get; set; } = 0;

    public int Value
    {
        get { return _value; }
    }

    public void Increase(int Score)
    {
        _value += Score;        
    }
    public static Score Instance
    {
        get
        {
            if (_instance == null)
                _instance = new Score();
            return _instance;
        }
    }
    public static TextMeshProUGUI TextMeshProUGUI
    {
        get
        {
            if (_textMeshProUGUI == null)
                _textMeshProUGUI = GameObject.Find("ScoreText_02").GetComponent<TextMeshProUGUI>();
            return _textMeshProUGUI;
        }
    }

}
