namespace ResizeImage;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
    private void OnButtonClicked(object sender, EventArgs e)
    {
        this.imageEditor.Save(imageSize: new Size(200, 200));
    }
}