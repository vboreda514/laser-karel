using Godot;
using System;

public partial class map_editor_button : Button
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	private void _on_pressed()
	{
		GetTree().ChangeSceneToFile("res://Scenes/map_editor_2d.tscn");
	}
}
