using System;
using System.Threading.Tasks;
using VkNet;
using VkNet.Enums.Filters;
using VkNet.Model;
using VkNet.Model.RequestParams;
using Xamarin.Forms;

namespace App7
{
    public partial class MainPage : ContentPage
    {
        private const long CommunityId = Сюда введите айди вашего сообщества; // ID вашего сообщества "ВКонтакте"
        private const long UserId = Сюда введите нужный user-id конкретного человека; // ID пользователя, которому вы хотите отправить сообщение
        private const string AccessToken = "Сюда введите ваш API из вк, гайд вы можете найти в интернете"; // API

        private VkApi api;

        public MainPage()
        {
            InitializeComponent();
            api = new VkApi();
            api.Authorize(new ApiAuthParams
            {
                AccessToken = AccessToken,
                Settings = Settings.Messages
            });
        }

        private async void Button1_Clicked(object sender, EventArgs e)
        {
            await SendMessage("Ваш текст1");
        }

        private async void Button2_Clicked(object sender, EventArgs e)
        {
            await SendMessage("Ваш текст2");
        }

        private async void Button3_Clicked(object sender, EventArgs e)
        {
            await SendMessage("Ваш текст3");
        }

        private async void Button4_Clicked(object sender, EventArgs e)
        {
            await SendMessage("Ваш текст4");
        }

        private async void Button_Clicked5(object sender, EventArgs e)
        {
            await SendMessage("Ваш текст5");
        }

        private async void Button_Clicked6(object sender, EventArgs e)
        {
            await SendMessage("Ваш текст6");
        }

        private async void Button_Clicked7(object sender, EventArgs e)
        {
            await SendMessage("Ваш текст7");
        }

        private async Task SendMessage(string message)
        {
            try
            {
                var parameters = new MessagesSendParams
                {
                    RandomId = new Random().Next(),
                    UserId = UserId,
                    Message = message
                };
                await api.Messages.SendAsync(parameters);
                await DisplayAlert("Успех", "Сообщение отправлено!", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ошибка", ex.Message, "OK");
            }
        }
    }
}
