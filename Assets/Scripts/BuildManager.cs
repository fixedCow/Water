using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager inst;

    private void Awake()
    {
        if (inst == null)
            inst = this;
    }
}
