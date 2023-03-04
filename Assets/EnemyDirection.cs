using UnityEngine;
using UnityEngine.UI;

public class EnemyDirection : MonoBehaviour
{
    [SerializeField] private Transform enemyTransform;
    [SerializeField] private float leftAngleThreshold = -45f;
    [SerializeField] private float rightAngleThreshold = 45f;
    [SerializeField] private Text directionText;

    private void Update()
    {
        Vector3 directionToEnemy = enemyTransform.position - transform.position;
        float angleToEnemy = Vector3.SignedAngle(transform.forward, directionToEnemy, Vector3.up);

        if (angleToEnemy > rightAngleThreshold)
        {
            directionText.text = "Enemy is on the right side of the player.";
        }
        else if (angleToEnemy < leftAngleThreshold)
        {
            directionText.text = "Enemy is on the left side of the player.";
        }
        else
        {
            directionText.text = "Enemy is in front of or behind the player.";
        }
    }
}
