﻿using DreamEase.Views;
using Microsoft.Extensions.Logging;
using Plugin.Maui.Audio;
using CommunityToolkit.Maui;

namespace DreamEase
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>().ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("MaterialIcons-Regular.ttf", "Icon");
            }).UseMauiCommunityToolkit();
            builder.Services.AddSingleton(AudioManager.Current);
            builder.Services.AddTransient<MusicListPage>();
#if DEBUG
            builder.Logging.AddDebug();
#endif
            return builder.Build();
        }
    }
}