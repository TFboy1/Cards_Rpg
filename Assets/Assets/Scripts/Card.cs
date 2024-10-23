public class Card
{
    public int Id;
    public string cardName;
    public Card(int _id,string _cardName) 
    {
        this.Id = _id;
        this.cardName = _cardName;
    }
}

public class Tiancard: Card//天道卡
{
    public int period;
    public string effect;
    public Tiancard(int _id, string _cardName, int _period, string _effect) : base(_id, _cardName)
    {
        period = _period;
        effect = _effect;
    }

}

public class Charactercard: Card
{
    public int move_speed;//人物的移动速度
    public int build_speed;//建造速度
    public int health_now;//现在的血量
    public int health_max;//最大血量
    public int attack_num;//攻击力
    public Charactercard(int _id, string _cardName, int _move_speed,int _build_speed,int _health_now, int _health_max,int _attack_num) : base(_id, _cardName)
    { 
        move_speed = _move_speed;   
        build_speed = _build_speed;
        health_now = _health_now;
        health_max = _health_max;
        attack_num = _attack_num;
    }

}

public class Dicard: Card //地理卡，就是地形
{
    public string Dieffect;//地形牌的效果
    public bool up_or_down;//用来声明是否可以攀登
    public Dicard(int _id, string _cardName,string _Dieffect, bool _up_or_down): base(_id, _cardName) 
    { 
        Dieffect = _Dieffect;
        up_or_down = _up_or_down;
    }
    
}
