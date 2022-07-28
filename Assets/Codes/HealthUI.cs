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
    private TextMeshProUGUI textMeshPro;

    public void Awake()
    {
        healthBar.maxValue = health.Value;
        healthBar.value = health.Value;
        textMeshPro = GameObject.Find("PlayerHealthText").GetComponent<TextMeshProUGUI>();
        //textMeshPro.text = $"HP:{healthBar.value.ToString()}";
    }

    public void UpdateUI()
    {
        healthBar.value = health.Value;
        //textMeshPro.text = $"HP:{healthBar.value.ToString()}";
        Debug.Log($"��ǰѪ��:{healthBar.value} ���Ѫ��:{healthBar.maxValue}");
    }

}
