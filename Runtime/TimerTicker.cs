using System;
using System.Collections;
using UnityEngine;

namespace ElRaccoone.Timers
{
    public class TimerTicker : MonoBehaviour
    {
        public IEnumerator EnumerateSetTimeout(int miliseconds, Action callback, bool unscaledTime)
        {
            if (unscaledTime)
                yield return new WaitForSecondsRealtime(miliseconds / 1000);
            else
                yield return new WaitForSeconds(miliseconds / 1000);
            callback();
        }

        public IEnumerator EnumerateSetInterval(int miliseconds, Action callback, bool unscaledTime)
        {
            if (unscaledTime)
                yield return new WaitForSecondsRealtime(miliseconds / 1000);
            else
                yield return new WaitForSeconds(miliseconds / 1000);
            callback();
            this.StartCoroutine(this.EnumerateSetInterval(miliseconds, callback, unscaledTime));
        }
    }
}