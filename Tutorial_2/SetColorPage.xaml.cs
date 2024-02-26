namespace Tutorial_2
{
    public partial class SetColorPage : ContentPage
    {
        int count = 0;
        bool triggered;
        string color_text = string.Empty;
        string color_image_path = string.Empty;

        public SetColorPage()
        {
            InitializeComponent();
        }

        async Task update_pic(string pic_path)
        {
            Color_Window.Source = pic_path;
        }

        private async void color_choice(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (clickedButton.Equals(REDbtn))
            {
                color_text = "red";
                color_image_path = "red_icon.png";
                Color_sample.Fill = new SolidColorBrush(Color.FromRgb(255, 0, 0));
            }
            else if (clickedButton.Equals(BLUEbtn))
            {
                color_text = "blue";
                color_image_path = "blue_icon.png";
                Color_sample.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 255));
            }
            else if (clickedButton.Equals(GREENbtn))
            {
                color_text = "green";
                color_image_path = "green_icon.png";
                Color_sample.Fill = new SolidColorBrush(Color.FromRgb(0, 255, 0));
            }
            else if (clickedButton.Equals(YELLOWbtn))
            {
                color_text="yellow";
                color_image_path = "yellow_icon.png";
                Color_sample.Fill = new SolidColorBrush(Color.FromRgb(240, 243, 7));
            }
            else if (clickedButton.Equals(PINKbtn))
            {
                color_text = "pink";
                color_image_path = "pink_icon.png";
                Color_sample.Fill = new SolidColorBrush(Color.FromRgb(243, 36, 215));
            }
            else
            {
                color_text = "orange";
                color_image_path = "orange_icon.png";
                Color_sample.Fill = new SolidColorBrush(Color.FromRgb(231, 156, 10));
            }

            Current_Color.Text = color_text;
            await update_pic(color_image_path);
            triggered = true;
        }
    }
}