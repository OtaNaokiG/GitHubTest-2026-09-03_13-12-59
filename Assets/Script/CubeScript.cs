using UnityEngine;

public class CubeScript : MonoBehaviour
{
    [SerializeField] private Vector3 maxSize;
    void Update()
    {
        Vector3 newScale = transform.localScale + Vector3.one * Time.deltaTime;

        newScale.x = Mathf.Min(newScale.x, maxSize.x);

        

        transform.localScale = newScale;
    }
}
