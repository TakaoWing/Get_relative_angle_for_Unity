using UnityEngine;
using UnityEngine.UI;

public class EnemyDirection : MonoBehaviour
{
    [SerializeField] private Transform enemyTransform;
    [SerializeField] private float angleThreshold = 45f;
    [SerializeField] private Text directionText;

    private void Update()
    {
        Vector3 directionToEnemy = enemyTransform.position - transform.position;
        float angleToEnemy = Vector3.SignedAngle(transform.forward, directionToEnemy, Vector3.up);

        if (Mathf.Abs(angleToEnemy) > angleThreshold)
        {
            if (angleToEnemy > 0f)
            {
                directionText.text = "Enemy is on the right.";
            }
            else
            {
                directionText.text = "Enemy is on the left.";
            }
        }
        else
        {
            directionText.text = "";
        }
    }
}
