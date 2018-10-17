using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MathHelper {

    public const float FloatEpsilon = 0.001f;

    public static int Sign(float value)
    {
        return value > 0.0f ? 1 : Mathf.Abs(value) < FloatEpsilon ? 0 : -1;
    }

}
