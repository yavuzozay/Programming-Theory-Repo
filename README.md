# Programming-Theory-Repo
 submission 2 for jr programmer pathway

 ## Inheritance
 PlayerBall ve EnemyBall base class olan BaseBall clasından miras almaktadır. Ortak olan fonksiyonlar ve değişebilecek fonksiyonlar olduğundan dolayı base class abstract olarak tanımlanmıştır.


## Polymorphism

````
   public virtual void DecreaseHP(float damage)
    {
        curHP -= damage;
        if (curHP <= 0)
            curHP = 0;
    }
````

````
public override void DecreaseHP(float damage)
    {
       base.DecreaseHP(damage);
       EventManager.Fire_onPlayerHPChanged(curHP, maxHP);

    }
````
## Abstraction

Spawn kontrol fonskiyonu içerisindeki adımların hepsinin amacı spawnlanacak objeyi belirlemektir.
````

    private void SpawnControl()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;
        if (enemyCount == 0)
        {
            GameManager.Instance.level++;
            SpawnEnemyWave(GameManager.Instance.level);
            SpawnObject(gem);

        }
    
    }
````
## Encapsulation
````
     [SerializeField] private int _health;
    [SerializeField] private int _power;


    //Encapsulation
    public int power
    {
        get { return _power; }
        set { _power = value; }
       
    }
    public int health
    {
        get { return _health; }
        set {
            if (_health > 0)
                _health = value;
           
        }
    }
````

