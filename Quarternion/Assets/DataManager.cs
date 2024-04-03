using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager
{
    public Dictionary<int, StatData> stat = new Dictionary<int, StatData>();
    public HashSet<BulletController> Bullets = new HashSet<BulletController>();
    public StatData Setting(bool _isPlater, int _max, int _bulletDMG, int _bulletLV, int _moveSPD)
    {
        StatData _data = new StatData();
        _data.maxHp = _max;
        _data.currentHp = _current;
        _data.bylletDamage = _bulletDMG;
        _data.moveSpeed = _moveSPD;
        if (_isPlater)
        {
            Init(_data, 0);
        }
        else
        {
            Init(_data, stat.Count);            
        }
        return _data;

    }

}
public class StatData
{
    public float maxHp;
    public float currentHp;
    public int bulletDamage;
    public int bulleLevel;
    public int moveSpeed;
}
