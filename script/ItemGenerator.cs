using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject applePrefab;
    public GameObject bombPrefab;
    float span = 1.0f;
    float delta = 0;
    float ratio = 4; //掉落物生成機率
    float speed = -0.05f; //掉落物生成速度

    public void SetParameter(float span, float ratio, float speed)
    {
        this.span = span;
        this.ratio = ratio;
        this.speed = speed;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > this.span)
        {
            this.delta = 0;
            GameObject item;
            int dice = Random.Range(1, 11);
            if(dice <= this.ratio)
            {
                item = Instantiate(bombPrefab);
            }
            else
            {
                item = Instantiate(applePrefab);
            }
            float[] posX = { -2f, 0.5f, 2f }; // 隨機生成位置
            float[] posZ = { -2f, 0f, 2f };
            float x = posX[Random.Range(0, 3)];
            float z = posZ[Random.Range(0, 3)];
            item.transform.position = new Vector3(x, 4f, z);
            item.GetComponent<ItemController>().dropspeed = this.speed;
        }
    }
}
