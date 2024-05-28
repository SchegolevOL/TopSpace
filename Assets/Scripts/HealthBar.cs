using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    Image image;

    private void Awake()
    {
        image = GetComponent<Image>();
    }

    public void SetBarValue(float currHP, float maxHP)
    {
        image.fillAmount = currHP / maxHP;
    }

}
