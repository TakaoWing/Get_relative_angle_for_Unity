using UnityEngine;

public class ObjectDirectionIndicator : MonoBehaviour
{
    [SerializeField] private float lineLength = 1f;

    private void OnDrawGizmos()
    {
        DrawLine();
    }

    private void OnDrawGizmosSelected()
    {
        DrawLine();
    }

    private void DrawLine()
    {
        Gizmos.color = Color.blue;

        Vector3 lineStart = transform.position;
        Vector3 lineEnd = transform.position + transform.forward * lineLength;

        Gizmos.DrawLine(lineStart, lineEnd);
        Debug.DrawLine(lineStart, lineEnd, Color.blue);
    }
}
