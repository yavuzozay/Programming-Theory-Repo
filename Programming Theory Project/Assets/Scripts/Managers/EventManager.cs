using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EventManager 
{
    public static event Action<float> onScoreChanged;
    public static void Fire_onScoreChanged(float score) { onScoreChanged?.Invoke(score); }

    public static event Action<float, float> onPlayerHPChanged;
    public static void Fire_onPlayerHPChanged(float currentHP, float maxHP) { onPlayerHPChanged?.Invoke(currentHP, maxHP); }
}
