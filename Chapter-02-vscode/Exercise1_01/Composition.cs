class Tiles { }

class Motor
{
    public void Move() { }
}

class Trap
{
    public void Damage() { }
}

class MovingTiles : Tiles
{
    private readonly Motor _motor;

    public MovingTiles(Motor motor)
    {
        _motor = motor;
    }

    public void Move()
    {
        _motor.Move();
    }
}

class TrapTiles : Tiles
{
    private readonly Trap _trap;
    public TrapTiles(Trap trap)
    {
        _trap = trap;
    }

    public void Damage()
    {
        _trap.Damage();
    }
}

class MovingTrapTile : Tiles
{
    private readonly Motor _motor;
    private readonly Trap _trap;

    public MovingTrapTile(Motor motor, Trap trap)
    {
        _motor = motor;
        _trap = trap;
    }

    public void Move()
    {
        _motor.Move();
    }

    public void Damage()
    {
        _trap.Damage();
    }
}