using UnityEngine;
using UnityEngine.UI;

public class EnemyRelativeDirection : MonoBehaviour
{
    [SerializeField] private Transform targetTransform;
    [SerializeField] private float angleThreshold = 45f;
    [SerializeField] private Text directionText;

    private void Update()
    {
        Vector3 directionToTarget = targetTransform.position - transform.position;
        float angleToTarget = Mathf.Atan2(directionToTarget.z, directionToTarget.x) * Mathf.Rad2Deg;

        if (Mathf.Abs(angleToTarget) > angleThreshold)
        {
            if (angleToTarget > 0f)
            {
                directionText.text = "On the right.";
            }
            else
            {
                directionText.text = "On the left.";
            }
        }
        else
        {
            directionText.text = "";
        }
    }
}
