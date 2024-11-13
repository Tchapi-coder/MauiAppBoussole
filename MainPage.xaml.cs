namespace MauiAppBoussole
{
    public partial class MainPage : ContentPage
    {
      

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert("La boussole", $"la nouvelle direction est {rotationLabel.Text}.", "ok");

             
        }

        private void Slider_ValueChanged(object sender, EventArgs e)
        {
            double rotation=((Slider)sender).Value;
            rotationLabel.Text = rotation + "°";
            boussoleImg.RotateTo(rotation);
        }
    }

}
