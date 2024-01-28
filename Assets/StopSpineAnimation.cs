using UnityEngine;
using Spine.Unity;

public class StopStartSpineAnimation : MonoBehaviour
{
    private SkeletonAnimation skeletonAnimation;
    private MeshRenderer meshRenderer;

    void Start()
    {
        // Assurez-vous que le GameObject a un composant SkeletonAnimation attaché
        skeletonAnimation = GetComponent<SkeletonAnimation>();
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled = true;

        if (skeletonAnimation == null)
        {
            Debug.LogError("SkeletonAnimation component not found!");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            meshRenderer.enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.F2))
        {
            meshRenderer.enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.F3))
        {
            meshRenderer.enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            meshRenderer.enabled = true;
        }
    }
}
