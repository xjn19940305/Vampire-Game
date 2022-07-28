using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Ѫ��
/// </summary>
public class HealthUI : MonoBehaviour
{
    [SerializeField] private Slider healthBar;
    [SerializeField] private Health health;
    [SerializeField] private TextMeshPro textMeshPro;

    public void Awake()
    {
        healthBar.maxValue = health.Value;
        healthBar.value = health.Value;
        //textMeshPro.text = health.Value.ToString();
    }

    public void UpdateUI()
    {
        healthBar.value = health.Value;
        Debug.Log($"��ǰѪ��:{healthBar.value} ���Ѫ��:{healthBar.maxValue}");
    }

}
