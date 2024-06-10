
using System.Windows;
using System.Windows.Controls;

namespace MVVMProject.Views.Components;


public partial class TextBoxWithLabel : UserControl
{
    public TextBoxWithLabel()
    {
        InitializeComponent();
    }
    public static readonly DependencyProperty LabelTextProperty =
    DependencyProperty.Register("LabelText", typeof(string), typeof(TextBoxWithLabel), new PropertyMetadata(string.Empty));

    public string LabelText
    {
        get { return (string)GetValue(LabelTextProperty); }
        set { SetValue(LabelTextProperty, value); }
    }

    public static readonly DependencyProperty TextBoxTextProperty =
        DependencyProperty.Register("TextBoxText", typeof(string), typeof(TextBoxWithLabel), new PropertyMetadata(string.Empty));

    public string TextBoxText
    {
        get { return (string)GetValue(TextBoxTextProperty); }
        set { SetValue(TextBoxTextProperty, value); }
    }

    public static readonly DependencyProperty TextBoxWidthProperty =
        DependencyProperty.Register("TextBoxWidth", typeof(double), typeof(TextBoxWithLabel), new PropertyMetadata(double.NaN));

    public double TextBoxWidth
    {
        get { return (double)GetValue(TextBoxWidthProperty); }
        set { SetValue(TextBoxWidthProperty, value); }
    }

    public static readonly DependencyProperty TextBoxHeightProperty =
        DependencyProperty.Register("TextBoxHeight", typeof(double), typeof(TextBoxWithLabel), new PropertyMetadata(double.NaN));

    public double TextBoxHeight
    {
        get { return (double)GetValue(TextBoxHeightProperty); }
        set { SetValue(TextBoxHeightProperty, value); }
    }



}
