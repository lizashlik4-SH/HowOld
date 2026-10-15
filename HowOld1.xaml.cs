using System.Xml.Linq;

namespace HowOld;

public partial class HowOld1 : ContentPage
{
	public HowOld1()
	{
		InitializeComponent();
        lblResult.Text = "---Welcome---";

    }

    private void Button_Clicked_Calculate(object sender, EventArgs e)
    {
        int age = 10 + int.Parse(Eage.Text);
        lblResult.Text = "In 10 years from now " + name.Text + " will be " + age + " years old"; 
    }
}