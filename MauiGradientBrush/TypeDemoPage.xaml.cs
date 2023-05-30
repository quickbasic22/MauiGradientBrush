using System.Windows.Input;

namespace MauiGradientBrush;

public partial class TypeDemoPage : ContentPage
{
    View view;
    public ICommand CreateCommand { get; private set; }
    public TypeDemoPage()
    {
        InitializeComponent();
        CreateCommand = new Command<Type>((Type viewType) =>
        {
            view = (View)Activator.CreateInstance(viewType);
            view.VerticalOptions = LayoutOptions.Center;
            stackLayout.Add(view);
        });
        BindingContext = this;
    }
}