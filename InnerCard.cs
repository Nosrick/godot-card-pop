using Godot;
using System;
using Environment = Godot.Environment;

public class InnerCard : Spatial
{
    [Export] protected NodePath ParentCameraPath;

    protected Camera ParentCamera;

    protected Camera Camera;
    
    public override void _Ready()
    {
        if (this.ParentCameraPath is null)
        {
            return;
        }

        this.ParentCamera = this.GetNode<Camera>(this.ParentCameraPath);
        
        this.Camera = new Camera();
        this.AddChild(this.Camera);

        //this.Camera.Environment = GD.Load<Environment>("inner_card_env.tres");
    }

    public override void _Process(float delta)
    {
        base._Process(delta);

        this.Camera.GlobalTransform = this.ParentCamera.GlobalTransform;
    }
}
