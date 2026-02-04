using UnityEngine;

public class movingPlatform : MonoBehaviour
{
    [SerializeField] public Transform platform, origin, target;

    [SerializeField] private bool movigTowardsTarget;
    [SerializeField] private float lerpTime, platformSpeed;

    private void start()
    {
        platform.position = origin.position;

    }

    private void Update()
    {
        if (movigTowardsTarget)
        {
            lerpTime += Time.deltaTime * platformSpeed;
            lerpTime = Mathf.Clamp(lerpTime, 0, 1);

            platform.position = Vector3.Lerp(origin.position, target.position, lerpTime);

            if(lerpTime >= 1)
            {
               movigTowardsTarget = false;
               lerpTime = 0;
            }
        }
        else
        {
            lerpTime += Time.deltaTime * platformSpeed;
            lerpTime = Mathf.Clamp(lerpTime, 0, 1);

            platform.position = Vector3.Lerp(target.position, origin.position, lerpTime);

            if (lerpTime >= 1)
            {
                movigTowardsTarget = true;
                lerpTime = 0;
            }
        }

    }
}
