using System;
using System.Collections;
using UnityEngine;

namespace ElRaccoone.Timers {
  public static class Timers {
    private static TimerTicker _Enumerator;
    private static TimerTicker Enumerator {
      get {
        if (_Enumerator == null) {
          _Enumerator = new GameObject ("~timers").AddComponent<TimerTicker> ();
          GameObject.DontDestroyOnLoad (_Enumerator);
        }
        return _Enumerator;
      }
    }

    public static void SetTimeout (int miliseconds, Action callback, bool unscaledTime) {
      Enumerator.StartCoroutine (Enumerator.EnumerateSetTimeout (miliseconds, callback, unscaledTime));
    }

    public static void SetInterval (int miliseconds, Action callback, bool unscaledTime) {
      Enumerator.StartCoroutine (Enumerator.EnumerateSetInterval (miliseconds, callback, unscaledTime));
    }

    public static void SetTimeout (this Transform target, int miliseconds, Action callback, bool unscaledTime) {
      Enumerator.StartCoroutine (Enumerator.EnumerateSetTimeout (miliseconds, callback, unscaledTime));
    }

    public static void SetInterval (this Transform target, int miliseconds, Action callback, bool unscaledTime) {
      Enumerator.StartCoroutine (Enumerator.EnumerateSetInterval (miliseconds, callback, unscaledTime));
    }

    public static void SetTimeout (this GameObject target, int miliseconds, Action callback, bool unscaledTime) {
      Enumerator.StartCoroutine (Enumerator.EnumerateSetTimeout (miliseconds, callback, unscaledTime));
    }

    public static void SetInterval (this GameObject target, int miliseconds, Action callback, bool unscaledTime) {
      Enumerator.StartCoroutine (Enumerator.EnumerateSetInterval (miliseconds, callback, unscaledTime));
    }
  }
}
