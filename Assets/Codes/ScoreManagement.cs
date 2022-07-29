using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManagement : MonoBehaviour
{

    public void Increase()
    {
        Score.Instance.Increase(1);
    }
    public void UpdateUI()
    {
        Score.TextMeshProUGUI.text = Score.Instance.Value.ToString();        
    }


}
