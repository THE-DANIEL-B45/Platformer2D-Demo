using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MenuButtonManager : MonoBehaviour
{
    public List<GameObject> buttons;

    [Header("Animation")]
    public float duration = 0.2f;
    public float delay = 0.05f;
    public Ease ease = Ease.OutBack;

    private void OnEnable()
    {
        HideAllButtons();
        ShowButtons();
    }

    private void HideAllButtons()
    {
        foreach (var button in buttons)
        {
            button.transform.localScale = Vector3.zero;
            button.SetActive(false);
        }
    }

    private void ShowButtons()
    {
        for (int i = 0; i < buttons.Count; i++)
        {
            var b = buttons[i];
            b.SetActive(true);
            b.transform.DOScale(Vector3.one, duration).SetDelay(i*delay).SetEase(ease);
        }
    }

}
