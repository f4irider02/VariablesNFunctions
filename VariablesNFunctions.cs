int ammo = 80;
int health = 100;
bool awesome;
float powerUp;
string name;

void Start()
{
    powerUp = 0;
    awesome = false;
}

public int GetAmmo()
{
    return ammo;
}

void UsePowerUp()
{
    powerUp--;
}