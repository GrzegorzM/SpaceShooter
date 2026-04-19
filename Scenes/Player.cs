using Godot;

public partial class Player : Node2D
{
	[Export]
	private Sprite2D _playerShip;

	[Export]
	private int _speed = 100;

	public override void _Ready()
	{
		Position = new Vector2(100, 200);
		_playerShip = GetNode<Sprite2D>("PlayerShip");
	}

	public override void _Process(double delta)
	{
		//Position += new Vector2(1, 0) * (float)delta;
		//_playerShip.Rotation += 0.1f * (float)delta;
		
		var direction = Input.GetVector(MyInput.Left, MyInput.Right, MyInput.Up, MyInput.Down);
		_playerShip.Position += direction * _speed * (float)delta;
		
		 //if(Input.IsActionPressed("ui_right")){
			//_playerShip.Position += new Vector2(100, 0) * (float)delta;
		//}
		//
		 //if(Input.IsActionPressed("ui_left")){
			//_playerShip.Position += new Vector2(-100, 0) * (float)delta;
		//}
		//
		 //if(Input.IsActionPressed("ui_up")){
			//_playerShip.Position += new Vector2(0, -100) * (float)delta;
		//}
		//if(Input.IsActionPressed("ui_down")){
			//_playerShip.Position += new Vector2(100, 0) * (float)delta;
		//}
		
		//GetNode<Sprite2D>("PlayerShip").Rotation += 0.1f * (float)delta;
		//GetNode("PlayerShip").Rotation += 0.1f * (float)delta;
	}
}
