# 1151-HW7-413262445--
撿水果模擬器，使用籃子在3x3的九宮格移動，接住所有掉落物(不要撿到蹦蹦炸彈)，並在有限的時間內(60s)，盡可能獲取1500分

物件配置:蘋果、炸彈、籃子、3x3九宮格

參數設置:

    物件掉落速度 -> ratio = -0.004f 
    
    物件產生速度 -> span = 1.0f

    炸彈生成比率 -> rate = 4   (每十個掉落物會有4個炸彈)

    當小於45s時每隔一段時間物件掉落速度會-0.0005f

    拾取蘋果+100 points
    拾取炸彈 point/2 並且 time -2s
    
<img width="1917" height="1018" alt="image" src="https://github.com/user-attachments/assets/2d92cdd3-32e3-4d93-90f5-4ecff55a0829" />

