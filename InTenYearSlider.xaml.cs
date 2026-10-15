namespace HowOld;

public partial class InTenYearSlider : ContentPage
{
   private int age ;

    public InTenYearSlider()
	{
		InitializeComponent();
        lblResult.Text = "---Welcome---";

    }
   
    private void Slide_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        age = (int)sliderAge.Value;
       Eage.Text = age.ToString();

    }

    private void sliderAge_DragCompleted(object sender, EventArgs e)
    {
        age = (int)sliderAge.Value;
        lblResult.Text = "In 10 years from now " + name.Text + " will be " + (age + 10) + " years old";

    }
}