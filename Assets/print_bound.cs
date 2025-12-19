using UnityEngine;

public class PrintBounds : MonoBehaviour
{
    void Start()
    {
        var r = GetComponentInChildren<Renderer>();
        var b = r.bounds;
        Debug.Log($"FLOOR SIZE (m): X={b.size.x:F2}, Y={b.size.y:F2}, Z={b.size.z:F2}");
    }
}
