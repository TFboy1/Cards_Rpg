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

public class Tiancard: Card//�����
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
    public int move_speed;//������ƶ��ٶ�
    public int build_speed;//�����ٶ�
    public int health_now;//���ڵ�Ѫ��
    public int health_max;//���Ѫ��
    public int attack_num;//������
    public Charactercard(int _id, string _cardName, int _move_speed,int _build_speed,int _health_now, int _health_max,int _attack_num) : base(_id, _cardName)
    { 
        move_speed = _move_speed;   
        build_speed = _build_speed;
        health_now = _health_now;
        health_max = _health_max;
        attack_num = _attack_num;
    }

}

public class Dicard: Card //���������ǵ���
{
    public string Dieffect;//�����Ƶ�Ч��
    public bool up_or_down;//���������Ƿ�����ʵ�
    public Dicard(int _id, string _cardName,string _Dieffect, bool _up_or_down): base(_id, _cardName) 
    { 
        Dieffect = _Dieffect;
        up_or_down = _up_or_down;
    }
    
}
