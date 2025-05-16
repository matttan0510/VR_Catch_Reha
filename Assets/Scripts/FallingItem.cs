using UnityEngine;

public class FallingItem : MonoBehaviour
{
    public float fallSpeed = 2f;

    void Start()
    {
        Debug.Log("Appleが出現したよ！");
    }

    void Update()
    {
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);

        if (transform.position.y < -5f)
        {
            Destroy(gameObject);
        }
    }

    // ←ここに注目！！
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("触れた相手: " + other.name);

        if (other.CompareTag("CatchZone"))
        {
            Debug.Log("キャッチ成功！");
            Destroy(gameObject);
        }
    }
}
