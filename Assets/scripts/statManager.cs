using UnityEngine;

public class statManager : MonoBehaviour
{
    public int collectedCoins;
    public int currentCheckpoint;

    public void ChangeCoins(int amountCollected)
    {
        collectedCoins += amountCollected;
        collectedCoins = Mathf.Clamp(collectedCoins, 0, 99);
    }

    public void TriggerCheckpoint(int checkpointIndex)
    {
        currentCheckpoint = checkpointIndex;
    }
}
