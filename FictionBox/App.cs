using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using FictionBox.Core.Services;
using FictionBox.Core.ViewModels;

namespace FictionBox.Core
{
    public class App : MvxApplication
    {
        public App()
        {
			Mvx.RegisterType<ICreateDecks, CreateDecks>();
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<DeckViewModel>());
        }
    }
}