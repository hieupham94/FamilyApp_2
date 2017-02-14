using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FamilyApp_2
{
    class Class1 : ContentPage
    {
        public Class1()
        {
            StackLayout stackLayout = new StackLayout()
            {
                Spacing = 3.0,
                BackgroundColor = Color.Gray,
                Children =
                {
                    new Label
                    {
                        HorizontalTextAlignment = TextAlignment.Center,
                        TextColor = Color.Red,
                        BackgroundColor = Color.White,
                        VerticalOptions = LayoutOptions.StartAndExpand,
                        FormattedText = new FormattedString
                        {
                            Spans =
                            {
                                new Span
                                {
                                    Text = "Myself",
                                    FontAttributes = FontAttributes.Bold,
                                    FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                                    ForegroundColor = Color.Black
                                },
                                new Span
                                {
                                    Text = ", There is nothing to write about me."
                                }
                            }
                        }
                    },
                    new Label
                    {
                        HorizontalTextAlignment = TextAlignment.Center,
                        VerticalTextAlignment = TextAlignment.Center,
                        TextColor = Color.Red,
                        FormattedText = new FormattedString
                        {
                            Spans =
                            {
                                new Span
                                {
                                    Text ="My dad",
                                    FontAttributes = FontAttributes.Bold,
                                    FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                                    ForegroundColor = Color.Blue
                                },
                                new Span
                                {
                                    Text = ", There is nothing to write about him."
                                }
                            }
                        }
                    },
                    new Label
                    {
                        HorizontalTextAlignment = TextAlignment.Center,
                        VerticalTextAlignment = TextAlignment.Center,
                        TextColor = Color.Red,
                        FormattedText = new FormattedString
                        {
                            Spans =
                            {
                                new Span
                                {
                                    Text ="My mom",
                                    FontAttributes = FontAttributes.Bold,
                                    FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                                    ForegroundColor = Color.Purple
                                },
                                new Span
                                {
                                    Text = ", There is nothing to write about her."
                                }
                            }
                        }
                    },
                    new Label
                    {
                        HorizontalTextAlignment = TextAlignment.Center,
                        VerticalTextAlignment = TextAlignment.Center,
                        TextColor = Color.Red,
                        FormattedText = new FormattedString
                        {
                            Spans =
                            {
                                new Span
                                {
                                    Text ="My brother",
                                    FontAttributes = FontAttributes.Bold,
                                    FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                                    ForegroundColor = Color.Red
                                },
                                new Span
                                {
                                    Text = ", There is nothing to write about my brother."
                                }
                            }
                        }
                    },
                    new Label
                    {
                        HorizontalTextAlignment = TextAlignment.Center,
                        VerticalTextAlignment = TextAlignment.Center,
                        TextColor = Color.Red,
                        FormattedText = new FormattedString
                        {
                            Spans =
                            {
                                new Span
                                {
                                    Text ="Mary",
                                    FontAttributes = FontAttributes.Bold,
                                    FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                                    ForegroundColor = Color.Green
                                },
                                new Span
                                {
                                    Text = ", This is the last paragraph. I can't see the different of layoutoptions."
                                }
                            }
                        }
                    },
                    new Label { Text = "1" },
                    new Label { Text = "2" },
                    new Label { Text = "3" },
                    new Label { Text = "4" },
                    new Label { Text = "5" },
                    new Label { Text = "6" },
                    new Label { Text = "7" },
                    new Label { Text = "8" },
                    new Label { Text = "9" },
                    new Label { Text = "10" },
                    new Label { Text = "1" },
                    new Label { Text = "2" },
                    new Label { Text = "3" },
                    new Label { Text = "4" },
                    new Label { Text = "5" },
                    new Label { Text = "6" },
                    new Label { Text = "7" },
                    new Label { Text = "8" },
                    new Label { Text = "9" },
                    new Label { Text = "10" },
                    new Label { Text = "1" },
                    new Label { Text = "2" },
                    new Label { Text = "3" },
                    new Label { Text = "4" },
                    new Label { Text = "5" },
                    new Label { Text = "6" },
                    new Label { Text = "7" },
                    new Label { Text = "8" },
                    new Label { Text = "9" },
                    new Label { Text = "10" },
                    new Label { Text = "1" },
                    new Label { Text = "2" },
                    new Label { Text = "3" },
                    new Label { Text = "4" },
                    new Label { Text = "5" },
                    new Label { Text = "6" },
                    new Label { Text = "7" },
                    new Label { Text = "8" },
                    new Label { Text = "9" },
                    new Label { Text = "10" }
                }
            };

            Content = new ScrollView
            {
                Content = stackLayout
            };
        }
    }
}
