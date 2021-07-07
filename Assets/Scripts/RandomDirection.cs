using UnityEngine;

public static class RandomDirection
{
    public static Vector3 GetRandomDir(this Vector3 Randomdir)
    {
        return new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
    }
}