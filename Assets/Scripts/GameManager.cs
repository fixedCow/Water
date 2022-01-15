using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager inst;

    public float EjaculationModule_WaterAmount_Mult;
    public float EjaculationModule_AttackCooldown_Mult;

    private void Awake()
    {
        if (inst == null)
            inst = this;
    }
}
