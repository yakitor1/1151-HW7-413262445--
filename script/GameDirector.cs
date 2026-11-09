using UnityEngine;
using TMPro;

public class GameDirector : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    GameObject timerText;
    GameObject pointText;
    GameObject winText;
    GameObject loseText;
    int point = 0;
    float time = 60.0f;
    GameObject generator;
    void Start()
    {
        this.timerText =  GameObject.Find("time");
        this.pointText = GameObject.Find("point");
        this.generator = GameObject.Find("ItemGenerator");
        this.winText = GameObject.Find("win");
        this.loseText = GameObject.Find("lose");
        this.winText.SetActive(false);
        this.loseText.SetActive(false);
    }

    public void getApple()
    {
        this.point += 100;
    }

    public void getBomb()
    {
        this.point /= 2;
        this.time -= 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        this.time -= Time.deltaTime;
        if(this.time < 0)
        {
            this.time = 0;
            this.generator.GetComponent<ItemGenerator>().SetParameter(10000.0f, 0, 0);
            if (this.point >= 1500)
            {
                // 分數大於等於1500顯示 Win
                this.winText.SetActive(true);
            }
            else
            {
                // 分數小於1500顯示 Lose
                this.loseText.SetActive(true);
            }
        }
        else if(0 <= this.time && this.time < 4)
        {
            this.generator.GetComponent<ItemGenerator>().SetParameter(0.3f, 0, -0.07f);
        }
        else if (4 <= this.time && this.time < 12)
        {
            this.generator.GetComponent<ItemGenerator>().SetParameter(0.5f, 6, -0.06f);
        }
        else if (12 <= this.time && this.time < 23)
        {
            this.generator.GetComponent<ItemGenerator>().SetParameter(0.8f, 4, -0.055f);
        }
        else if (23 <= this.time && this.time < 45)
        {
            this.generator.GetComponent<ItemGenerator>().SetParameter(1.0f, 2, -0.05f);
        }
        this.timerText.GetComponent<TextMeshProUGUI>().text = this.time.ToString("F1");
        this.pointText.GetComponent<TextMeshProUGUI>().text = this.point.ToString() + "point";
    }
}
