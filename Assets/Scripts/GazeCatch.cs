using UnityEngine;

public class GazeCatch : MonoBehaviour
{
    public float maxDistance = 10f;

    void Update()
    {
        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, maxDistance))
        {
            if (hit.collider.CompareTag("Apple"))
            {
                Debug.Log("見つめてキャッチ！");
                Destroy(hit.collider.gameObject);
            }
        }
    }
}
