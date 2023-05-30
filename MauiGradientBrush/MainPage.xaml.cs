using System.Numerics;


namespace MauiGradientBrush;

public partial class MainPage : ContentPage
{
	Vector2 Vector2 { get; set; }
	public MainPage()
	{
		InitializeComponent();
        Vector2 vector = new Vector2(2, 3);
        Vector3 vector3 = new Vector3(2, 3, 5);
        Vector4 vector4 = new Vector4(2, 3, 4, 5);
        Matrix3x2 matrix = new Matrix3x2(2, 0, 0, 3, 4, 5);
        Matrix4x4 matrix3 = new Matrix4x4(2, 0, 0, 3, 4, 5, 2, 0, 0, 3, 4, 5, 2, 0, 0, 3);
        Matrix4x4 matrix4 = new Matrix4x4(2, 0, 0, 3, 4, 5, 2, 0, 0, 3, 4, 5, 0, 2, 3, 4);

        Vector2 result = Vector2.Transform(vector, matrix);
        var result3 = Vector3.Transform(vector3, matrix3);
        var result4 = Vector4.Transform(vector4, matrix4);



    }
}

