using BaseLib.ByteIdentify;

namespace Dispatcher.Pages;


public partial class RealTimePage : ContentPage
{
	public RealTimePage()
	{
		InitializeComponent();
		ByteBaseIdentify.CheckSum(new byte[5]);

    }
}