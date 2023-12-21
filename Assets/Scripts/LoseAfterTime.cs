using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LoseAfterTime : MonoBehaviour
{
    public UnityEvent action;
    public float time = 1.0f;

    public void Lose()
    {
        StartCoroutine(Going());
    }

    private IEnumerator Going()
    {
        yield return new WaitForSeconds(time);
        action?.Invoke();
    }
}
