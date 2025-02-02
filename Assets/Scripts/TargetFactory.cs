using UnityEngine;

public class TargetFactory : MonoBehaviour
{
    // Reference to the Target prefab (assign in Inspector)
    public GameObject targetPrefab;

    // Method to create a target at a specified position.
    public Target CreateTarget(Vector3 position)
    {
        GameObject targetObject = Instantiate(targetPrefab, position, Quaternion.identity);
        Target target = targetObject.GetComponent<Target>();
        return target;
    }


    public void Start()
    {
        CreateMultipleTargets(10);
    }
    // Example: Create multiple targets
    public void CreateMultipleTargets(int count)
    {
        for (int i = 0; i < count; i++)
        {
            // Randomize position or use your own placement logic.
            Vector3 position = new Vector3(Random.Range(-6, 6), 0.3f, Random.Range(-6, 6));
            CreateTarget(position);
        }
    }
}