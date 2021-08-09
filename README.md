# Programming-Theory-Repo
 submission 2 for jr programmer pathway

 ## Inheritance
 
EnemyX, EnemyBoss inherit from Enemy class.<br>

in Enemy class
````  

  protected void FollowPlayer(float speed)
    {
        if (GameManager.Instance.isGameActive)
        {
            Vector3 lookDirection = (player.transform.position - transform.position).normalized;
            enemyRb.AddForce(lookDirection * speed);
        }
        else
        {
            enemyRb.Sleep();
        }

    }
````
EnemyBoss class
````
private void Update()
    {
        //inheritance

        FollowPlayer();
      

    }
````
## Polymorphism
````
protected virtual  void DealDamage(int damage)
    {
        player.GetComponent<Player>().health -= damage;
    }
````

````
 protected override void DealDamage(int damage)
    {
        //Customize
        base.DealDamage(damage);
    }
````
## Abstraction
````
private void Update()
    {
        //Abstraction
        SpawnControl();
    }
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

