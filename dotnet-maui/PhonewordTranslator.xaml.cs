using System.Text;

namespace dotnet_maui;

public partial class PhonewordTranslator : ContentPage
{
    public PhonewordTranslator()
    {
        InitializeComponent();
    }

    //string translatedNumber;

    //private void OnTranslate(object sender, EventArgs e)
    //{
    //    string enteredNumber = PhoneNumberText.Text;
    //    translatedNumber = PhonewordTranslator.ToNumber(enteredNumber);

    //    if (!string.IsNullOrEmpty(translatedNumber))
    //    {
    //        CallButton.IsEnabled = true;
    //        CallButton.Text = "Call " + translatedNumber;
    //    }
    //    else
    //    {
    //        CallButton.IsEnabled = false;
    //        CallButton.Text = "Call";
    //    }
    //}

    //async void OnCall(object sender, System.EventArgs e)
    //{
    //    if (await this.DisplayAlert(
    //"Dial a Number",
    //"Would you like to call " + translatedNumber + "?",
    //"Yes",
    //"No"))
    //    {
    //        try
    //        {
    //            if (PhoneDialer.Default.IsSupported)
    //                PhoneDialer.Default.Open(translatedNumber);
    //        }
    //        catch (ArgumentNullException)
    //        {
    //            await DisplayAlert("Unable to dial", "Phone number was not valid.", "OK");
    //        }
    //        catch (Exception)
    //        {
    //            // Other error has occurred.
    //            await DisplayAlert("Unable to dial", "Phone dialing failed.", "OK");
    //        }
    //    }
    //}

    //private static string ToNumber(string raw)
    //{
    //    if (string.IsNullOrWhiteSpace(raw))
    //        return null;

    //    raw = raw.ToUpperInvariant();

    //    var newNumber = new StringBuilder();
    //    foreach (var c in raw)
    //    {
    //        if (" -0123456789".Contains(c))
    //            newNumber.Append(c);
    //        else
    //        {
    //            var result = TranslateToNumber(c);
    //            if (result != null)
    //                newNumber.Append(result);
    //            // Bad character?
    //            else
    //                return null;
    //        }
    //    }
    //    return newNumber.ToString();
    //}

    //static bool Contains(this string keyString, char c)
    //{
    //    return keyString.IndexOf(c) >= 0;
    //}

    //static readonly string[] digits = {
    //    "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ"
    //};

    //static int? TranslateToNumber(char c)
    //{
    //    for (int i = 0; i < digits.Length; i++)
    //    {
    //        if (digits[i].Contains(c))
    //            return 2 + i;
    //    }
    //    return null;
    //}
}