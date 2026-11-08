using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject applePrefab;
    public GameObject bombPrefab;
    float span = 1.0f;
    float delta = 0;
    float ratio = 4; //掉落物生成機率
    float speed = -0.03f;

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
            float x = (Random.Range(0, 3) * 2) - 2;
            float z = (Random.Range(0, 3) * 2) - 2;
            item.transform.position = new Vector3(x, 4f, z);
            item.GetComponent<ItemController>().dropspeed = this.speed;
        }
    }
}
