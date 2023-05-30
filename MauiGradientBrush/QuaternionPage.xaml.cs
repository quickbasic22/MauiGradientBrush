using Microsoft.Maui.Controls;
using Microsoft.Maui.Layouts;
using System.Numerics;

namespace MauiGradientBrush;

public partial class QuaternionPage : ContentPage
{
    public double BoxViewTranslationX { get; set; }
    public double BoxViewTranslationY { get; set; }
    public float BoxViewRotation { get; set; }

    public Quaternion MyQuaternion { get; set; }

    public QuaternionPage()
	{
		InitializeComponent();
        BindingContext = this;

        // Calculate the translation values to center the BoxView
        BoxViewTranslationX = (DeviceDisplay.MainDisplayInfo.Width - 100) / 2; // Adjust 100 to match the BoxView's width
        BoxViewTranslationY = (DeviceDisplay.MainDisplayInfo.Height - 100) / 2; // Adjust 100 to match the BoxView's height

        // Define the initial rotation angle
        float initialAngle = 30f;

        // Convert the initial rotation angle to radians
        float initialAngleRadians = DegreesToRadians(initialAngle);

        // Create a Quaternion with the initial rotation angle
        Quaternion rotationQuaternion = Quaternion.CreateFromYawPitchRoll(100, 100, initialAngleRadians);

        // Convert the Quaternion to a rotation matrix
        Matrix4x4 rotationMatrix = Matrix4x4.CreateFromQuaternion(rotationQuaternion);

        // Apply the rotation matrix to the BoxView
        rotatingBoxView.Rotation = RadiansToDegrees(Math.Atan2(rotationMatrix.M21, rotationMatrix.M11));

        // Rotate the BoxView by an additional 200 degrees
        float additionalRotation = 200f;

        // Convert the additional rotation to radians
        float additionalRotationRadians = DegreesToRadians(additionalRotation);

        // Create a Quaternion for the additional rotation
        Quaternion additionalRotationQuaternion = Quaternion.CreateFromYawPitchRoll(100, 100, additionalRotationRadians);

        // Combine the initial and additional rotations
        Quaternion combinedRotation = rotationQuaternion * additionalRotationQuaternion;

        // Convert the combined Quaternion to a rotation matrix
        rotationMatrix = Matrix4x4.CreateFromQuaternion(combinedRotation);

        // Apply the rotation matrix to the BoxView
        rotatingBoxView.Rotation = RadiansToDegrees(Math.Atan2(rotationMatrix.M21, rotationMatrix.M11));
    }

    private float DegreesToRadians(float degrees)
    {
        return (float)(degrees * (Math.PI / 180));
    }

    private float RadiansToDegrees(double radians)
    {
        return (float)(radians * (180 / Math.PI));
    }
}